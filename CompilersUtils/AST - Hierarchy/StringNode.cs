using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;

namespace CompilersUtils
{
    public class StringNode:InstructionNode
    {
        public string Value { get; set; }
        public StringNode(string value)
        {
            Value = value;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            ReturnType = new TypeInfo("string",null,TypeDecl.Base);
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            cg.Emit(OpCodes.Ldstr, Value);
        }
    }
}
