using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class IfThenNode:ControlNode,IBreakable
    {
        public TigerNode ExprIf { get; set; }
        public TigerNode ExprThen { get; set; }
        bool havebreak;

        public IfThenNode(TigerNode exprIf, TigerNode exprThen)
        {
            ExprIf = exprIf; ExprThen = exprThen;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            ExprIf.CheckSemantic(scope, errors);

            if (ExprIf.ReturnType!= null && ExprIf.ReturnType.BaseType.Name != "int")
                errors.Add(new Error(Row, Col, "The condition's expressions of <if-then> must be an int"));

            ExprThen.CheckSemantic(scope, errors);
            if (ExprThen is IBreakable)
                havebreak = ((IBreakable)ExprThen).HaveBreak;

            if (ExprThen.ReturnType!= null && ExprThen.ReturnType.BaseType.Name != "void")
                errors.Add(new Error(Row, Col, "The body's expressions of <if-then> must not return a value"));

            ReturnType = scope.ExistType("void");

        }
       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            ExprIf.GenCode(tb, mb, cg); ////aqui condition.gencode
            cg.Emit(OpCodes.Ldc_I4_0);
            Label end = cg.DefineLabel();
            cg.Emit(OpCodes.Beq, end);
            ////aqui thenexpr.gencode
            ExprThen.GenCode(tb, mb, cg);
            ////
            cg.MarkLabel(end);
        }

        bool IBreakable.HaveBreak
        {
            get
            {
                return havebreak;
            }
        }
    }
}
