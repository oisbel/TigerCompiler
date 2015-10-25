using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class FunctionsBlockNode:DeclarationBlockNode
    {
        public static List<string> FunctionsLibrary = new List<string> { "print", "printi", "flush", "getchar", "ord", "chr", "size", "substring", "concat", "not", "exit", "printline", "getline" };
        public List<FunctionDeclNode> Functions { get; set; }
        public FunctionsBlockNode(List<FunctionDeclNode> functions)
        {
            Functions = functions;
        }
        
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            //limpio el bloque de funciones temporales
            scope.TempFunctions = new List<FunctionDeclNode>();
            int temp = errors.Count();
            //agrego las funciones a la lista temporal 
            foreach (var function in Functions)
            {
                if (scope.TempFunctions.Contains(function))
                    errors.Add(new Error(Row, Col, string.Format("Already exist a function named \"{0}\" in this block",function.IdFunction)));
                else
                    scope.TempFunctions.Add(function);                
            }
            CheckHeader(scope.TempFunctions,errors,scope);
            if (temp == errors.Count())
            {
                //chekeo la semantice de cada funcion en el bloque
                foreach (var function in Functions)
                {
                    function.CheckSemantic(scope, errors);
                }
            }          
        }

        public void CheckHeader(List<FunctionDeclNode> listf,List<Error> errors,Scope scope) 
        {            
            foreach (FunctionDeclNode function in listf)
            {
                //busco si existe una funcion en el scope con ese mismo nombre
                FunctionInfo f = scope.Functions.ContainsKey(function.IdFunction) ? scope.Functions[function.IdFunction] : null;

                //busco si existe una variable en el scope con el mismo nombre
                //ya q variables y funciones comparten el mismo namespace
                VarInfo v = scope.Variables.ContainsKey(function.IdFunction) ? scope.Variables[function.IdFunction] : null;

                //si ya esta definida esa funcion en el scope lo agrego a los errores
                if (f != null)
                    errors.Add(new Error(Row, Col, string.Format("The function \"{0}\" is already exist in this scope", function.IdFunction)));//si ya existe en el scope del padre
                //si hay una variable con ese nombre lanzo un error
                else if (v != null)
                    errors.Add(new Error(Row, Col, string.Format("Already exist a variable named \"{0}\"", function.IdFunction)));
                //no se puede definir una funcion con el mismo nombre de alguna de la libreria
                //sino lanzo un error
                foreach (var func in FunctionsLibrary)
                {
                    if (function.IdFunction == func)
                        errors.Add(new Error(Row, Col, string.Format("Cannot create a function named \"{0}\"", function.IdFunction)));
                }
                //chekeo q no haya 2 params con el mismo nombre
                foreach (var parameters in function.Parameters)
                {
                    List<Parameter> equals = function.Parameters.FindAll(p => p.Id == parameters.Id);
                    if (equals.Count() > 1)
                    {
                        errors.Add(new Error(Row, Col, string.Format("Cannot be 2 parameters with the same name")));
                        break;
                    }
                }
                //chekeo q el tipo de todos los parametros este definido
                foreach (var parameter in function.Parameters)
                {
                    TypeInfo t1 = scope.ExistType(parameter.Type);
                    if (t1 == null)
                        errors.Add(new Error(Row, Col, string.Format("The type of parameter \"{0}\" is not defined", parameter.Id)));
                }                		 
            }
        }
       
        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            throw new NotImplementedException();
        }
    }
}
