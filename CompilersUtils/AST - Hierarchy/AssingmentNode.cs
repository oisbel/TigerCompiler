using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class AssingmentNode:InstructionNode
    {
        public TigerNode LeftExpr { get; set; }
        public TigerNode RigthExpr { get; set; }

        public AssingmentNode(TigerNode left, TigerNode rigth)
        {
            LeftExpr = left; RigthExpr = rigth;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            string id_var = "";
            //chekeo la semantica del lvalue
            LeftExpr.CheckSemantic(scope, errors);
            TypeInfo t = LeftExpr.ReturnType;

            //en el caso de q sea una variable guardo 
            //su valor para despues compararlo con el id del ciclo
            if (LeftExpr is VariableNode)
                id_var = ((VariableNode)LeftExpr).Value;
            

            //chekeo la semantica del rvalue            
            RigthExpr.CheckSemantic(scope, errors);
            TypeInfo t1 = RigthExpr.ReturnType;

            if (t != null && t1 != null && t.Name != t1.Name)
            {
                if (t1.Name == "nil")
                {
                    if (t.Name == "int")
                        errors.Add(new Error(Row, Col, string.Format("Cannot assign nil to an int")));
                }
                else if(t1.Name == "void")
                    errors.Add(new Error(Row, Col, string.Format("The expression that try assign to \"{0}\" not return value", t.Name)));
                else
                    errors.Add(new Error(Row, Col, string.Format("Cannot asssign  \"{0}\" to  \"{1}\"", t1.Name, t.Name)));
            }
            else
            {
                if (countLoop >0  && id_var == scope.IdLoop)
                    errors.Add(new Error(Row, Col, string.Format("Cannot assign any value to variable \"{0}\" of <for>", scope.IdLoop)));
            }
            ReturnType = new TypeInfo("void", null, TypeDecl.Base);
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            RigthExpr.GenCode(tb, mb, cg);
            assign = true;
            LeftExpr.GenCode(tb, mb, cg);
        }
    }
}
