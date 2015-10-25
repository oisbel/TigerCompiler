using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public abstract class RelationalOpNode : BinaryOpNode
    {
        public RelationalOpNode(TigerNode expr1,TigerNode expr2):base(expr1,expr2){}
        public void CheckSemantic(Scope scope, List<Error> errors, string op)
        {
            string type = "";
            string type1 = "";

            //comprobando la semantica del primer operando
            LeftOperand.CheckSemantic(scope, errors);

            if (RigthOperand != null)
            {
                //coumpruebo que sea int el tipo de retorno
                if (LeftOperand.ReturnType != null && LeftOperand.ReturnType.BaseType.Name == "int") type = "int";
                //sino veo si es string
                else if (LeftOperand.ReturnType!= null && LeftOperand.ReturnType.BaseType.Name == "string") type = "string";
                //sino lanzo un error porq solo puede ser estos dos tipos
                else
                    errors.Add(new Error(Row, Col, string.Format("The left operand in \"{0}\" operator must be return an int or a string", op)));

                //compruebo la semantica del segundo operando
                RigthOperand.CheckSemantic(scope, errors);

                
                //coumpruebo que sea int el tipo de retorno
                if (RigthOperand.ReturnType!= null && RigthOperand.ReturnType.BaseType.Name == "int") type1 = "int";
                //sino veo si es string
                else if (RigthOperand.ReturnType!= null && RigthOperand.ReturnType.BaseType.Name == "string") type1 = "string";
                //sino lanzo un error porq solo puede ser estos dos tipos
                else
                    errors.Add(new Error(Row, Col, string.Format("The rigth operand in \"{0}\" must be return an int or a string", op)));


                //compruebo que ambos sean int o string
                if (type1 != type)
                {
                    errors.Add(new Error(Row, Col, string.Format("The left and rigth operand in \"{0}\" operator may be either both <integer> or both <string>", op)));
                }
                ReturnType = new TypeInfo("int", null, TypeDecl.Base);

            }
            else
            {
                ReturnType = LeftOperand.ReturnType;
            }

        }

       
    }
}
