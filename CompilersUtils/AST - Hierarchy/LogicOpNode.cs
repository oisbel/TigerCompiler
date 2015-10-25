using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public abstract class LogicOpNode:BinaryOpNode
    {
        public LogicOpNode(TigerNode expr1, TigerNode expr2) : base(expr1, expr2) { }

        public void CheckSemantic(Scope scope, List<Error> errors, string op)
        {
            
            //coumpruebo sintacticamente el primer operando
            LeftOperand.CheckSemantic(scope, errors);

            if (RigthOperand != null)
            {
                //compruebo q el tipo de retorno del operando izq sea int
                if (LeftOperand.ReturnType!= null &&LeftOperand.ReturnType.BaseType.Name != "int")
                    errors.Add(new Error(Row, Col, string.Format("The left operand in \"{0}\" operator must be return an int", op)));

                //coumpruebo sintacticamente el segundo operando
                RigthOperand.CheckSemantic(scope, errors);

                //compruebo q el tipo de retorno sea int
                if (RigthOperand.ReturnType != null && RigthOperand.ReturnType.BaseType.Name != "int")
                    errors.Add(new Error(Row, Col, string.Format("The rigth operand in \"{0}\" operator must be return an int", op)));

                // pongo su tipo de retorno en int
                ReturnType = new TypeInfo("int",null,TypeDecl.Base);
            }
            else
            {
                ReturnType = LeftOperand.ReturnType;
            }
        }
    }
}
