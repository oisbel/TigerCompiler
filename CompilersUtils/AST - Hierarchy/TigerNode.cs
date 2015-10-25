using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;

namespace CompilersUtils
{
    public abstract class TigerNode:ProgramNode
    {
        public abstract void CheckSemantic(Scope scope,List<Error> errors);
        public abstract void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg);
        public static bool assign;
        
        public static int countLoop = 0;
    }
}
