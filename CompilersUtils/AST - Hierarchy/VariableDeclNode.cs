using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class VariableDeclNode:DeclarationNode
    {
        public string IdVar { get; set; }
        public string IdType { get; set; }
        public TigerNode Expr { get; set; }

        public VariableDeclNode(string id, string type, TigerNode expr)
        {
            IdVar = id; Expr = expr; IdType = type;
        }
        public VariableDeclNode(string id, TigerNode expr) : this(id, "", expr) { }

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            TypeInfo t = null;
            int count = errors.Count;

            //busco si existe una variable en el scope con el mismo nombre
            VarInfo v = scope.Variables.ContainsKey(IdVar) ? scope.Variables[IdVar] : null;

            //busco si existe una funcion en el scope con el mismo nombre
            //ya q variables y funciones comparten el mismo namespace
            FunctionInfo f = scope.Functions.ContainsKey(IdVar) ? scope.Functions[IdVar] : null;

            //si ya esta definida esa variable en el scope lo agrego a los errores
            if (v != null)
                errors.Add(new Error(Row, Col, string.Format("The variable \"{0}\" is already exist in this scope", IdVar)));
            //si hay una funcion con ese nombre lanzo un error
            else if (f != null)
                errors.Add(new Error(Row, Col, string.Format("Already exist a function with name \"{0}\"", IdVar)));
            else
            {
                int temp = errors.Count();
                //chekeo la semantica de la expr
                Expr.CheckSemantic(scope, errors);


                if (IdType == "")//cuando no esta especifcado el tipo
                {
                    //no puede ser null porq  no le podria inferir el tipo
                    if (Expr.ReturnType!= null && Expr.ReturnType.Name == "nil")
                        errors.Add(new Error(Row, Col, string.Format("Cannot assign <nil> to a variable without explicit type")));
                    if (Expr.ReturnType != null && Expr.ReturnType.Name == "void")
                        errors.Add(new Error(Row, Col, string.Format("Cannot infer the type of the variable \"{0}\"", IdVar)));                    
                    t = Expr.ReturnType;
                }
                else
                {
                    t = scope.ExistType(IdType);
                    //cuando no esta en los tipos definidos lanzo un error
                    if (t == null)
                        errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" could not be found", IdType)));

                    //esta pero no es el mismo q el del retorno de expr                     
                    if (t != null && Expr.ReturnType!= null && t.Name != Expr.ReturnType.Name)
                    {
                        if (!AreAlias(t, Expr.ReturnType))
                        {
                            //string type = t.BaseType.Name;
                            //si no es de tipo int o string o record  y expr retorna nil lanzo un error
                            if (Expr.ReturnType!= null && Expr.ReturnType.BaseType.Name == "nil")
                            {
                                if (t.IsInt)
                                    errors.Add(new Error(Row, Col, string.Format("Cannot assign <nil> to a varible of type \"{0}\"", IdType)));
                            }
                            else
                                errors.Add(new Error(Row, Col, string.Format("Cannot assisgn \"{0}\" to a variable of type \"{1}\"", Expr.ReturnType.Name, IdType)));
                        }
                    }

                    //en el caso de que sea un record verifico q los campos del record estan en el mimso orden
                    if (t != null && Expr.ReturnType!= null && t.typedecl == TypeDecl.Record && Expr.ReturnType.BaseType.Name != "nil")
                    {
                        for (int i = 0; i < t.Record_parameters.Count; i++)
                        {
                            if (t.Record_parameters[i].Type != Expr.ReturnType.Record_parameters[i].Type) errors.Add(new Error(Row, Col, string.Format("The fields is'nt the order correct")));
                        }
                    }
                }
            }
            //cuando no hay errores
            if (count == errors.Count)
            {
                VarInfo var = new VarInfo(IdVar, t);
                scope.Variables.Add(IdVar, var);               
            }
            ReturnType = new TypeInfo("void", null, TypeDecl.Base);
        }

        public bool AreAlias(TypeInfo t, TypeInfo t1)
        {

            while (t.typedecl == TypeDecl.Alias)
            {
                t = t.Parent;
                if (t.Name == t1.Name) return true;
            }

            while (t1.typedecl == TypeDecl.Alias)
            {
                t1 = t1.Parent;
                if (t1.Name == t.Name) return true;
            }
            return false;
        }
        

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            FieldBuilder fb;
            if (Expr.ReturnType.Name == "nil")
                fb = tb.DefineField(IdVar, Compiler.SearchType(IdType), FieldAttributes.Public | FieldAttributes.Static);
            else
                fb = tb.DefineField(IdVar, Compiler.SearchType(Expr.ReturnType.Name), FieldAttributes.Public | FieldAttributes.Static);
            Expr.GenCode(tb, mb, cg);
            cg.Emit(OpCodes.Stsfld, fb);
            Compiler.Variables.Add(new VarStack(IdVar, fb));
        }
    }
}
