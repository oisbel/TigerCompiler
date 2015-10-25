using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class IfThenElseNode:ControlNode,IBreakable 
    {
        public TigerNode ExprIf { get; set; }
        public TigerNode ExprThen { get; set; }
        public TigerNode ExprElse { get; set; }
        bool havebreak;

        public IfThenElseNode(TigerNode exprIf, TigerNode exprThen, TigerNode exprElse)
        {
            ExprIf = exprIf; ExprElse = exprElse; ExprThen = exprThen;
        }

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {

            ExprIf.CheckSemantic(scope, errors);

            if (ExprIf.ReturnType!= null && ExprIf.ReturnType.BaseType.Name != "int")
                errors.Add(new Error(Row, Col, "The condition's expressions of <if-then-else> must be an int"));

            ExprThen.CheckSemantic(scope, errors);
            if (ExprThen is IBreakable)
                havebreak = ((IBreakable)ExprThen).HaveBreak;
            TypeInfo t = ExprThen.ReturnType;

            ExprElse.CheckSemantic(scope, errors);
            if (ExprElse is IBreakable)
                havebreak = ((IBreakable)ExprElse).HaveBreak;
            TypeInfo t1 = ExprElse.ReturnType;

            if (t.Name != t1.Name)
            {
                errors.Add(new Error(Row, Col, string.Format("The second and third expressions of <if-then-else> must be of the same type")));
            }
            else ReturnType = t;
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            ExprIf.GenCode(tb, mb, cg); ////aqui condition.gencode
            cg.Emit(OpCodes.Ldc_I4_0);
            Label elselabel = cg.DefineLabel();
            cg.Emit(OpCodes.Beq, elselabel);
            ////aqui thenexpr.gencode
            ExprThen.GenCode(tb, mb, cg);
            ////
            Label endlabel = cg.DefineLabel();
            cg.Emit(OpCodes.Br, endlabel);
            cg.MarkLabel(elselabel);
            ////aqui elseexpr.gencode
            ExprElse.GenCode(tb,mb,cg);
            ////
            cg.MarkLabel(endlabel);
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
