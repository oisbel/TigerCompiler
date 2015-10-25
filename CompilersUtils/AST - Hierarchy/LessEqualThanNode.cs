using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class LessEqualThanNode:RelationalOpNode
    {
        public LessEqualThanNode(TigerNode expr1,TigerNode expr2):base(expr1,expr2){}
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            base.CheckSemantic(scope, errors, "<=");
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            LeftOperand.GenCode(tb, mb, cg);
            RigthOperand.GenCode(tb, mb, cg);

            if (LeftOperand.ReturnType.Name == "int")
            {
                cg.Emit(OpCodes.Cgt);
                cg.Emit(OpCodes.Ldc_I4_0);
                cg.Emit(OpCodes.Ceq);
                return;
            }
            //si es string utilizo el CompareTo
            MethodInfo compareTo = typeof(string).GetMethod("CompareTo", new Type[] { typeof(string) });
            cg.Emit(OpCodes.Call, compareTo);
            cg.Emit(OpCodes.Ldc_I4_1);
            cg.Emit(OpCodes.Clt);

        }
    }
}
