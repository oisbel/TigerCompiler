using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class IntNode:InstructionNode
    {
        public int Value { get; set; }
        public IntNode(int value)
        {
            Value = value;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            ReturnType = new TypeInfo("int",null,TypeDecl.Base);
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            cg.Emit(OpCodes.Ldc_I4, Value);
        }
    }
}
