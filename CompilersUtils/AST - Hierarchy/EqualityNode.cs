using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public abstract class EqualityNode:BinaryOpNode
    {
        public EqualityNode(TigerNode expr1,TigerNode expr2):base(expr1,expr2){}
        public void CheckSemantic(Scope scope, List<Error> errors, string op)
        {            
            string type = "";
            string type1 = "";

            //comprobando la semantica del primer operando
            LeftOperand.CheckSemantic(scope, errors);

            if (RigthOperand != null)
            {
                //guardo el tipo de retorno del operando izquierdo
                if (LeftOperand.ReturnType!= null && LeftOperand.ReturnType.BaseType.Name == "int") type = "int";
                //sino veo si es string
                else if (LeftOperand.ReturnType != null && LeftOperand.ReturnType.BaseType.Name == "string") type = "string";
                //sino veo si es un record
                else if (LeftOperand.ReturnType != null && LeftOperand.ReturnType.typedecl == TypeDecl.Record) type = "record";
                //sino veo si es array
                else if (LeftOperand.ReturnType != null && LeftOperand.ReturnType.typedecl == TypeDecl.Array) type = "array";
                //sino veo si es nil
                else if (LeftOperand.ReturnType != null && LeftOperand.ReturnType.BaseType.Name == "nil") type = "nil";
                //sino lanzo un error porq solo puede ser uno de estos tipos
                else
                    errors.Add(new Error(Row, Col, string.Format("The left operand in \"{0}\" operator must be one of the defined types", op)));

                
                //compruebo la semantica del segundo operando
                RigthOperand.CheckSemantic(scope, errors);

                //gurado el tipo de retorno del segundo operando
                if (RigthOperand.ReturnType != null && RigthOperand.ReturnType.BaseType.Name == "int") type1 = "int";
                //sino veo si es string
                else if (RigthOperand.ReturnType != null &&  RigthOperand.ReturnType.BaseType.Name == "string") type1 = "string";
                //sino veo si es un record
                else if (RigthOperand.ReturnType != null && RigthOperand.ReturnType.typedecl == TypeDecl.Record) type1 = "record";
                //sino veo si es array
                else if (RigthOperand.ReturnType != null && RigthOperand.ReturnType.typedecl == TypeDecl.Array) type1 = "array";
                //sino veo si es nil
                else if (RigthOperand.ReturnType != null && RigthOperand.ReturnType.BaseType.Name == "nil") type1 = "nil";
                //sino lanzo un error porq solo puede ser estos dos tipos
                else
                    errors.Add(new Error(Row, Col, string.Format("The rigth operand in \"{0}\" must be one of the defined types", op)));

                
                //si son de distintos tipos y ninguno es nil lanzo un error
                if (type1 != type)
                {
                    if(type != "nil" && type1 != "nil")
                        errors.Add(new Error(Row, Col, string.Format("The left and rigth operand in \"{0}\" operator may be either of the same type", op)));
                }
                //si son del mismo tipo pero nil lanzo un error
                else if (type == "nil")
                {
                    errors.Add(new Error(Row, Col, string.Format("The left and rigth operand in \"{0}\" operator can't be nill", op)));
                }

                // actualizo su tipo de retorno en int
                ReturnType = new TypeInfo("int", null, TypeDecl.Base);

            }
            else
            {
                ReturnType = LeftOperand.ReturnType;
            }

        }
    }
}
