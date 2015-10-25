using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public interface IBreakable
    {
        bool HaveBreak { get;}
    }
    public class BreakNode:ControlNode,IBreakable
    {
        bool havebreak = false;
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            if (countLoop <= 0)
                errors.Add(new Error(Row, Col, "The break is illegal outside <for> or <while>"));
            else
                havebreak = true;
           
            ReturnType = scope.ExistType("void");
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            cg.Emit(OpCodes.Br, Compiler.ends.Peek());
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
