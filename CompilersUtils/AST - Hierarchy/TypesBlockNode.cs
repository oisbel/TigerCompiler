using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class TypesBlockNode:DeclarationBlockNode
    {
        public List<TypeDeclNode> Types { get; set; }
        public TypesBlockNode(List<TypeDeclNode> types)
        {
            Types = types; 
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            scope.TempTypes = new List<TypeDeclNode>();
            foreach (var t in Types)
            {
                scope.TempTypes.Add(t);                
            }
            foreach (var t in Types)
            {
                t.CheckSemantic(scope, errors);                
            }
            if (scope.TypesToCheck.Count() > 0)
            {
                scope.TypesToCheck.Reverse();
                for (int i = 0; i < scope.TypesToCheck.Count();i++)
                {
                    TypeInfo t = scope.TypesToCheck[i];
                    if (t.typedecl == TypeDecl.Array)
                    {
                        TypeArrayNode res = (TypeArrayNode)scope.TempTypes.Find(type => type.Id == t.Name);
                        TypeInfo t1 = scope.ExistType(res.Type);//busco si ya existe el tipodel array
                        if (t1 != null)
                        {
                            t.Type = t1;
                            scope.Types.Add(t.Name, t);
                            scope.TypesToCheck.RemoveAt(i);
                        }
                    }
                    if (t.typedecl == TypeDecl.Alias)
                    {
                        TypeInfo type = scope.ExistType(t.Parent.Name);
                        if (type != null)
                        {
                            t.Parent = type;
                            scope.Types.Add(t.Name, t);
                            scope.TypesToCheck.RemoveAt(i);
                        }

                    }
                }
            }
            //chekeo por segunda vez los q se kedaron
            if (scope.TypesToCheck.Count() > 0)
            {
                
                for(int i = 0; i < scope.TypesToCheck.Count();i++)
                {
                    TypeInfo t = scope.TypesToCheck[i];
                    if (t.typedecl == TypeDecl.Array)
                    {
                        TypeArrayNode res = (TypeArrayNode)scope.TempTypes.Find(type => type.Id == t.Name);
                        TypeInfo t1 = scope.ExistType(res.Type);//busco si ya existe el tipodel array
                        if (t1 == null)
                        {
                            errors.Add(new Error(Row, Col, string.Format("The type of the array is not defined")));
                        }
                        else
                        {
                            t.Type = t1;
                            scope.Types.Add(t.Name, t);
                            scope.TypesToCheck.Remove(t);
                        }
                    }
                    if (t.typedecl == TypeDecl.Alias)
                    {
                        TypeInfo type = scope.ExistType(t.Parent.Name);
                        if (type != null)
                        {
                            t.Parent = type;
                            
                            scope.Types.Add(t.Name, t);
                            scope.TypesToCheck.RemoveAt(i);
                        }
                        else
                        {
                            errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" do not not pass through record or array", t.Name)));
                        }
                    }
                }
                scope.TypesToCheck.Clear();
            }
            
        }
      
        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            throw new NotImplementedException();
        }
    }
}
