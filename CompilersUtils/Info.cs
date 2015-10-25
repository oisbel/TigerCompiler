using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
        public class VarInfo
        {
            public string Id { get; set; }
            public TypeInfo Type { get; set; }
            public VarInfo(string id, TypeInfo type)
            { Id = id; Type = type; }
        }

        public enum TypeDecl { Array, Record, Alias, Base };
        
        public class TypeInfo
        {
            public string Name { get; set; }
            public TypeInfo Parent { get; set; }//para cuando es un alias
            public TypeDecl typedecl;
            public List<Parameter> Record_parameters { get; set; }//Para guardar los campos de los records
            public TypeInfo Type { get; set; }
            public int Length { get; set; }

            public TypeInfo(string name, TypeInfo parent, TypeDecl decl)
            {
                Name = name;
                Parent = parent;
                typedecl = decl;//para saber si es una de las decl del enum
            }

            public TypeInfo BaseType
            {
                get
                {
                    TypeInfo t = this;
                    while (t != null && t.Name != "int" && t.Name != "string" && t.Name != "void" && t.Name != "nil" && t.typedecl != TypeDecl.Array && t.typedecl != TypeDecl.Record)//mientras no sea uno de los tipos base
                    {
                        t = t.Parent;
                    }
                    if (t.typedecl == TypeDecl.Array)
                        return t.Type;
                    else return t;
                }
            }
            public bool IsArray
            {
                get
                {
                    TypeInfo t = this;
                    while (t != null && t.typedecl == TypeDecl.Alias)//mientras sea un alias
                    {
                        t = t.Parent;
                    }
                    return (t.typedecl == TypeDecl.Array) ? true : false;

                }
            }
            public bool IsRecord
            {
                get
                {
                    TypeInfo t = this;
                    while (t != null && t.typedecl == TypeDecl.Alias)//mientras sea un alias
                    {
                        t = t.Parent;
                    }
                    return (t.typedecl == TypeDecl.Record) ? true : false;

                }
            }
            public bool IsInt
            {
                get
                {
                    TypeInfo t = this;
                    while (t != null && t.typedecl == TypeDecl.Alias)
                    {
                        t = t.Parent; 
                    }
                    return (t.typedecl == TypeDecl.Base && t.Name == "int") ? true : false;
                }
            }
        }

        public class FunctionInfo
        {
            public string Id { get; set; }
            public TypeInfo ReturnType { get; set; }
            public List<Parameter> Parameters { get; set; }
            public FunctionInfo(string id, TypeInfo type, List<Parameter> parameters)
            { Id = id; ReturnType = type; Parameters = parameters; }
        }

        public class Parameter
        {
            public string Id { get; set; }
            public string Type { get; set; }
            public Parameter(string id, string type)
            {
                Id = id; Type = type; 
            }
        }      
           
}


