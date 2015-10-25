using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class FunctionDeclNode:DeclarationNode
    {
        public static List<string> FunctionsLibrary = new List<string> { "print", "printi", "flush", "getchar", "ord", "chr", "size", "substring", "concat", "not", "exit", "printline", "getline" };
        public string IdFunction { get; set; }
        public string IdType { get; set; }
        public TigerNode Expr { get; set; }
        public List<Parameter> Parameters { get; set; }

        public FunctionDeclNode(string idFunction, string idType, List<Parameter> parameters, TigerNode expr)
        { 
            IdFunction = idFunction; IdType = idType; Expr = expr; Parameters = parameters;
        }

        public FunctionDeclNode(string idFunction, List<Parameter> parameters, TigerNode expr) : this(idFunction, "void", parameters, expr) { }

        public override bool Equals(object obj)
        {
            FunctionDeclNode f = (FunctionDeclNode)obj;
            return (this.IdFunction==f.IdFunction)? true:false;
        }

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            int loops = countLoop;
            countLoop = 0;
            int count = errors.Count();
            TypeInfo t = null;

            //creo un nuevo scope para la funcion
            Scope func_scope = new Scope(scope);

            foreach (var param in Parameters)
            {
                func_scope.Variables.Add(param.Id, new VarInfo(param.Id, scope.ExistType(param.Type)));
            }

            //cuando esta dentro de un bloque
            //agrego todas las funciones al scope local para
            //que puedan ser llamadas dentro de esta
            if (scope.TempFunctions.Count() != 0)
            {
                foreach (var function_decl in scope.TempFunctions)
                {
                    if (function_decl.IdType == "")
                        func_scope.Functions.Add(function_decl.IdFunction, new FunctionInfo(function_decl.IdFunction, new TypeInfo("void", null, TypeDecl.Base), function_decl.Parameters));
                    else
                        func_scope.Functions.Add(function_decl.IdFunction, new FunctionInfo(function_decl.IdFunction, scope.ExistType(function_decl.IdType), function_decl.Parameters));
                }
            }
            //para cuando sea un proceso(no retorna valor)
            if (IdType == "void")
            {

                //cheekeo la semantica de expr
                Expr.CheckSemantic(func_scope, errors);
                //el tipo de retorno de expr tiene q ser void ya q es un proceso
                if (Expr.ReturnType!= null && Expr.ReturnType.Name != "void")
                    errors.Add(new Error(Row, Col, string.Format("The procedure \"{0}\"cannot return any value", IdFunction)));

                t = new TypeInfo("void", null, TypeDecl.Base);

            }
            //para cuando es un funcion (retorna valor)
            else
            {
                t = scope.ExistType(IdType);
                //cuando no esta en los tipos definidos lanzo un error
                if (t == null)
                    errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" could not be found", IdType)));
                else
                {
                    //cheekeo la semantica de expr
                    Expr.CheckSemantic(func_scope, errors);

                    //esta pero no es el mismo q el del retorno de expr                                      
                    if (Expr.ReturnType != null && t.BaseType.Name != Expr.ReturnType.BaseType.Name)
                        errors.Add(new Error(Row, Col, string.Format("The return type of \"{0}\" must be {1}", IdFunction, IdType)));
                }

            }           
            //si no hay errores de ningun tipo
            if (count == errors.Count())
            {
                //agrego la funcion al scope global
                FunctionInfo func = new FunctionInfo(IdFunction, t, Parameters);
                scope.Functions.Add(IdFunction, func);
                ReturnType = new TypeInfo("void", null, TypeDecl.Base);
            }
            countLoop = loops;
        }

       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            MethodBuilder function = Compiler.SearchFunction(IdFunction);//ya los metodos estan declaradosy lo genero aqui...mas tarde es que cierro la clse que contiene el metodo

            ILGenerator cgFunction = function.GetILGenerator();

            Expr.GenCode(tb, function, cgFunction);
            cgFunction.Emit(OpCodes.Ret);
        }
        
    }
}
