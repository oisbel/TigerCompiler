using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class TypeArrayNode:TypeDeclNode
    {
        public string Type { get; set; }
        public TypeArrayNode(string id,string type)
        {
            Id = id; Type = type;
        }

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            bool toCheck = false;
            //busco si hay un tipo con ese mismo nombre en el scope local
            TypeInfo t = scope.Types.ContainsKey(Id) ? scope.Types[Id] : null;
            int temp = errors.Count;
            if (Id == Type)
                errors.Add(new Error(Row, Col, string.Format("The array \"{0}\" can't be recursive",Id)));
            if (Id == "string")
                errors.Add(new Error(Row, Col, string.Format("Cannot declarate a type named <string>")));
            if (Id == "int")
                errors.Add(new Error(Row, Col, string.Format("Cannot declarate a type named <int>")));
            //si ya esta existe lo agrego a los errors
            if (t != null) 
                errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" is already defined in this scope", Id)));

            //busco si el tipo del array esta definido en el scope global
            TypeInfo t1 = scope.ExistType(Type);
            //si no esta definido el scope global lo agrego a los errors
            if (t1 == null)
            {
                bool exist = false;
                foreach (var ty in scope.TempTypes)
                {
                    if (ty.Id == Type) { exist = true; toCheck = true; break; }                  
                }
                if(!exist)
                    errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" is not defined in this scope", Type)));
            }
                       
            if (temp == errors.Count)//si no hay errores
            {
                TypeInfo res = new TypeInfo(Id, null, TypeDecl.Array);                

                if (!toCheck)
                {
                    res.Type = t1;
                    scope.Types.Add(Id, res);
                }
                else
                {                    
                    scope.TypesToCheck.Add(res);
                }
            }

            ReturnType = scope.ExistType("void");
        }

       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            Compiler.Types.Add(new TypeStack(Id, typeof(Array), Type));//no es pecifico el tipo por si no se ha creado aun
        }
    }
}
