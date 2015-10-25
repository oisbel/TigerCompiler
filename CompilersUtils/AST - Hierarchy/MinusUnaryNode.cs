using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class MinusUnaryNode:UnaryOpNode
    {
        public TigerNode Expr { get; set; }
        public MinusUnaryNode(TigerNode expr)
        {
            Expr = expr;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            //chekeo la semantica de la expr
            Expr.CheckSemantic(scope, errors);

            //compruebo q el tipo de retorno de expr sea int
            if (Expr.ReturnType!= null && Expr.ReturnType.BaseType.Name != "int") errors.Add(new Error(Row, Col, "The expression must be return an int"));

            //pongo el tipo de retorno del nodo en int
            ReturnType = new TypeInfo("int", null, TypeDecl.Base);
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            Expr.GenCode(tb, mb, cg);
            cg.Emit(OpCodes.Neg);
        }
    }
}
