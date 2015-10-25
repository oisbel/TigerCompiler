using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class FieldRecordNode:LValueNode
    {
        public string Field { get; set; }
        public TigerNode Expr { get; set; }

        public FieldRecordNode(string field,TigerNode expr)
        {
            Field = field; Expr = expr;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            string type = "";

            Expr.CheckSemantic(scope, errors);

            //compruebo q la var sea de tipo record
            if (Expr.ReturnType != null && Expr.ReturnType.typedecl != TypeDecl.Record)
                errors.Add(new Error(Row, Col, string.Format("The expression must be record type")));
            else
            {
                //compruebo que el record tenga un campo con ese nombre sino lanzo un error    
                type = HaveField(Expr.ReturnType);
                if (type == "")
                    errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" don't have any field \"{1}\"", Expr.ReturnType.Name, Field)));
            }

            ReturnType = scope.ExistType(type);
        }

        string HaveField(TypeInfo t)
        {
            
            for (int i = 0; i < t.Record_parameters.Count(); i++)
            {
                if (Field == t.Record_parameters[i].Id) return t.Record_parameters[i].Type;
            }
            return "";
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            if (assign)
            {
                assign = false;
                Type t = Compiler.SearchType(Expr.ReturnType.Name);
                FieldInfo fi = t.GetField(Field);
                LocalBuilder lb = cg.DeclareLocal(fi.FieldType);

                cg.Emit(OpCodes.Stloc, lb);
                Expr.GenCode(tb, mb, cg);
                cg.Emit(OpCodes.Ldloc, lb);
                cg.Emit(OpCodes.Stfld, fi);//en fi del id.gencode se queda el valor de la expresion de la derecha
            }
            else
            {
                Type t = Compiler.SearchType(Expr.ReturnType.Name);
                FieldInfo fi = t.GetField(Field);
                Expr.GenCode(tb, mb, cg);
                cg.Emit(OpCodes.Ldfld, fi);//el valor de fi del id.gencode se pone en la pila      
            }
        }
    }
}
