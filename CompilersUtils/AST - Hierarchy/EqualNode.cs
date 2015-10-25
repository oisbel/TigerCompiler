using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class EqualNode:EqualityNode
    {
        public EqualNode(TigerNode expr1,TigerNode expr2):base(expr1,expr2){}
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            base.CheckSemantic(scope, errors, "=");
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            LeftOperand.GenCode(tb, mb, cg);
            RigthOperand.GenCode(tb, mb, cg);

            if (LeftOperand.ReturnType.Name == "int" && RigthOperand.ReturnType.Name == "int")
            {
                cg.Emit(OpCodes.Ceq);
                return;
            }
            //si son string o record o array
            MethodInfo equal = typeof(Object).GetMethod("Equals", new Type[] { typeof(Object), typeof(Object) });
            MethodInfo toInt = typeof(Convert).GetMethod("ToInt32", new Type[] { typeof(bool) });
            cg.Emit(OpCodes.Call, equal);
            cg.Emit(OpCodes.Call, toInt);

        }
    }
}
