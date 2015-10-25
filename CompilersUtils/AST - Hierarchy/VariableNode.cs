using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class VariableNode:LValueNode
    {
        public string Value { get; set; }
        public VariableNode(string value)
        {
            Value = value;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            VarInfo v = scope.ExistVariable(Value);
            if (v == null)
                errors.Add(new Error(Row, Col, string.Format("The variable \"{0}\" doesn't exist in the current scope", Value)));
            else ReturnType = v.Type;
        }

       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            FieldBuilder fb = Compiler.SearchVariable(Value);
            if (assign)
            {
                assign = false;
                cg.Emit(OpCodes.Stsfld, fb);
            }
            else
            {
                cg.Emit(OpCodes.Ldsfld, fb);
            }
        }
    }
}
