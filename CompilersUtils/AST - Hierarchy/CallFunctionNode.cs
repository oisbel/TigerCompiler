using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class CallFunctionNode:InstructionNode
    {
        public string IdFunction { get; set; }
        public List<TigerNode> Params { get; set; }

        public CallFunctionNode(string idFunction,List<TigerNode> parameters)
        {
            IdFunction = idFunction; Params = parameters;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            //busco si existe una funcion en el scope
            FunctionInfo f = scope.ExistFunctions(IdFunction);

            //si no esta lanzo un error
            if (f == null)
                errors.Add(new Error(Row, Col, string.Format("Doesn't exist any function with name \"{0}\"", IdFunction)));
            else
            {
                //chekeo q la ctadad de parametros sea la misma
                if (Params.Count != f.Parameters.Count)
                    errors.Add(new Error(Row,Col,string.Format("The function \"{0}\" don't receive {1} parameter(s)",IdFunction,Params.Count())));
                //chekeo q los parametros sean del mismo tipo de la funcion
                for (int i = 0; i < Params.Count(); i++)
                {
                    //chekeo la semantica de cada expr
                    Params[i].CheckSemantic(scope, errors);
                    TypeInfo temp = scope.ExistType(f.Parameters[i].Type);
                    //si no tiene problemas veo que sea del tipo correcto
                    if (Params[i].ReturnType != null && Params[i].ReturnType.BaseType.Name != temp.BaseType.Name)
                    {
                        if (Params[i].ReturnType.BaseType.Name == "nil")
                        {
                            if (temp.BaseType.Name == "int")
                                errors.Add(new Error(Row, Col, string.Format("The parameters \"{0}\" must be <{1}>", i + 1, f.Parameters[i].Type)));
                        }
                        else
                        {
                            errors.Add(new Error(Row, Col, string.Format("The parameters \"{0}\" must be <{1}>", i + 1, f.Parameters[i].Type)));
                        }
                    }
                }
                ReturnType = f.ReturnType;
            }
            
        }

       
        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            switch(IdFunction)
            {
                case "print":
                    {
                        Params[0].GenCode(tb,mb,cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["print"], null); 
                        break; 
                    }
                case "printi":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["printint"], null);
                        break;
                    }
                case "concat":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        Params[1].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["concat"], null);
                        break;
                    }
                case "printline":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["printline"], null);
                        break;
                    }
                case "getline":
                    {
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["getline"], null);
                        break;
                    }
                case "getchar":
                    {
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["getchar"], null);
                        break;
                    }
                case "size":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["size"], null);
                        break;
                    }
                case "not":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["not"], null);
                        break;
                    }
                case "substring":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        Params[1].GenCode(tb, mb, cg);
                        Params[2].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["substring"], null);
                        break;
                    }
                case "exit":
                    {
                        Params[0].GenCode(tb, mb, cg);
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["exit"], null);
                        break;
                    }
                case "flush":
                    {
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["flush"], null);
                        break;
                    }
                case "ord":
                    {
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["ord"], null);
                        break;
                    }
                case "chr":
                    {
                        cg.EmitCall(OpCodes.Call, Compiler.funciones["chr"], null);
                        break;
                    }
                default:
                    {
                        List<VarStack> varParams = Compiler.SearchParameterFunction(IdFunction);//para almacenar los parametros
                        List<LocalBuilder> saveVar = new List<LocalBuilder>();//para almacenar todas las variables(incluso los parametros)

                        //guardo todas las variables
                        for (int i = 0; i < Compiler.Variables.Count; i++)
                        {
                            LocalBuilder lb = cg.DeclareLocal(Compiler.Variables[i].fb.FieldType);
                            cg.Emit(OpCodes.Ldsfld, Compiler.Variables[i].fb);
                            cg.Emit(OpCodes.Stloc, lb);
                            saveVar.Add(lb);
                        }

                        //Genero codigo de las expresiones y la guardo en varPrams
                        for (int i = 0; i < Params.Count; i++)
                        {
                            Params[i].GenCode(tb, mb, cg);
                            cg.Emit(OpCodes.Stsfld, varParams[i].fb);
                        }
                        //llamo a la funcion
                        cg.EmitCall(OpCodes.Call, Compiler.SearchFunction(IdFunction), null);//call llama al metodo con cero parametros.los paramtros son var public

                        //restablesco las variables
                        for (int i = 0; i < Compiler.Variables.Count; i++)
                        {
                            cg.Emit(OpCodes.Ldloc, saveVar[i]);
                            cg.Emit(OpCodes.Stsfld, Compiler.Variables[i].fb);
                        }
                        break; 
                    }
            }
            
        }
    }
}
