using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class WhileNode:ControlNode
    {
        public TigerNode ExprWhile { get; set; }
        public TigerNode ExprDo { get; set; }

        public WhileNode(TigerNode exprWhile, TigerNode exprDo)
        {
            ExprWhile = exprWhile; ExprDo = exprDo;
        }

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            countLoop++;           

            ExprWhile.CheckSemantic(scope, errors);

            if (ExprWhile.ReturnType!= null && ExprWhile.ReturnType.BaseType.Name != "int")
                errors.Add(new Error(Row, Col, "The first expression of <while> must be an int"));
            else
            {
                ExprDo.CheckSemantic(scope, errors);

                if (ExprDo.ReturnType!= null && ExprDo.ReturnType.BaseType.Name != "void")
                    errors.Add(new Error(Row, Col, "The body's expression of <while> must not return a value"));
            }
            ReturnType = scope.ExistType("void");

            countLoop--;
        }

       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            //// 
            Label inicio = cg.DefineLabel();
            cg.MarkLabel(inicio);
            ExprWhile.GenCode(tb,mb,cg);
            cg.Emit(OpCodes.Ldc_I4_0);
            Label end = cg.DefineLabel();
            Compiler.ends.Push(end);
            cg.Emit(OpCodes.Beq, end);
            ////aqui es donde va expr.gencode
            ExprDo.GenCode(tb,mb,cg);
            ////
            cg.Emit(OpCodes.Br, inicio);
            cg.MarkLabel(end);
            Compiler.ends.Pop();
        }
    }
}
