using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class TypeAliasNode:TypeDeclNode
    {        
        public string Type { get; set; }
        
        public TypeAliasNode(string id,string type )
        {
            Id = id; Type = type;    
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            bool toCheck = false;
            //busco si hay un tipo con ese mismo nombre en el scope local
            TypeInfo t = scope.Types.ContainsKey(Id) ? scope.Types[Id] : null;
            int temp = errors.Count;
            if (Id == "string" )
                errors.Add(new Error(Row, Col, string.Format("Cannot declarate a type named <string>")));
            if (Id == "int")
                errors.Add(new Error(Row, Col, string.Format("Cannot declarate a type named <int>")));
            //si ya esta definido lo agrego a los errors
            if (t!= null)
                errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" is already defined in this scope", Id)));

            //veo si el tipo es un tipo definido
            TypeInfo t1 = scope.ExistType(Type);
            //si no esta definido el padre lo agrego a los errores
            if (t1 == null)
            {
                //baseType = t1.BaseType.Name;
                bool exist = false;
                foreach (var ty in scope.TempTypes)
                {
                    if (ty.Id == Type) { exist = true; toCheck = true; break; }                    
                }
                if(!exist)
                    errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" is not defined", Type)));
            }

            if (temp == errors.Count)//si no hay errores
            {
                TypeInfo res = new TypeInfo(Id, t1, TypeDecl.Alias);                
               
                if (!toCheck)
                {
                    res.Type = t1.Type;//parche
                    baseType = t1.BaseType.Name;
                    if (t1.IsRecord) res.Record_parameters = t1.Record_parameters;
                    scope.Types.Add(Id, res);
                }
                else 
                {
                    res.Parent = new TypeInfo(Type,null,TypeDecl.Base);
                    scope.TypesToCheck.Add(res);
                }
            }
            
            ReturnType = scope.ExistType("void");
        }

       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            TypeStack typeStack = null;
            for (int i = Compiler.Types.Count - 1; i >= 0; i--)
            {
                if (Compiler.Types[i].name == baseType)//busco el tipo base para hacer el alias( esta en el scope
                {
                    Type type = null;
                    type = Compiler.Types[i].type;
                    typeStack = new TypeStack(Id, type, Compiler.Types[i].typeArray);                    
                    Compiler.Types.Add(typeStack);
                    break;
                }              
            }
        }
    }
}
