using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class OrNode:LogicOpNode
    {
        public OrNode(TigerNode expr1,TigerNode expr2):base(expr1,expr2){}
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            base.CheckSemantic(scope, errors, "|");
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            LeftOperand.GenCode(tb, mb, cg);
            RigthOperand.GenCode(tb, mb, cg);
            cg.Emit(OpCodes.Or);
        }
    }
}
