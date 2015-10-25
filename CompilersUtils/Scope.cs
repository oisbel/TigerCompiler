using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{    
    public class Scope
    {
        public Dictionary<string, VarInfo> Variables { get; set; }
        public Dictionary<string, TypeInfo> Types { get; set; }
        public Dictionary<string, FunctionInfo> Functions { get; set; }
        public List<FunctionDeclNode> TempFunctions { get; set; }
        public List<TypeDeclNode> TempTypes { get; set; }
        public List<TypeInfo> TypesToCheck { get; set; }
        Scope parent;
        
        public bool HaveBreak { get; set; }
        public string IdLoop { get; set; }
        

        public Scope(Scope parent)
        {
            this.parent = parent;
            Variables = new Dictionary<string, VarInfo>();
            Types = new Dictionary<string, TypeInfo>();
            Functions = new Dictionary<string, FunctionInfo>();
            TempFunctions = new List<FunctionDeclNode>();
            TempTypes = new List<TypeDeclNode>();
            TypesToCheck = new List<TypeInfo>();
        }
        public void InitiScope()
        {
            Types.Add("int", new TypeInfo("int",null,TypeDecl.Base));
            Types.Add("string", new TypeInfo("string",null,TypeDecl.Base));
            Types.Add("void", new TypeInfo("void",null,TypeDecl.Base));
            Types.Add("nil", new TypeInfo("nil",null,TypeDecl.Base));
            Types.Add("Record", new TypeInfo("Record", null, TypeDecl.Record));
            Types.Add("Array", new TypeInfo("Array", null, TypeDecl.Array));
            Functions.Add("print", new FunctionInfo("print", Types["void"], new List<Parameter> { new Parameter("s", "string") }));
            Functions.Add("printi", new FunctionInfo("printi", Types["void"], new List<Parameter> { new Parameter("i", "int") }));
            Functions.Add("flush", new FunctionInfo("flush", Types["void"], new List<Parameter> { }));
            Functions.Add("getchar", new FunctionInfo("getchar", Types["string"], new List<Parameter> { }));
            Functions.Add("ord", new FunctionInfo("ord", Types["int"], new List<Parameter> { new Parameter("s", "string") }));
            Functions.Add("chr", new FunctionInfo("chr", Types["string"], new List<Parameter> { new Parameter("i", "int") }));
            Functions.Add("size", new FunctionInfo("size", Types["int"], new List<Parameter> { new Parameter("s", "string") }));
            Functions.Add("substring", new FunctionInfo("substring", Types["string"], new List<Parameter> { new Parameter("s", "string"),new Parameter("f","int"),new Parameter("n","int") }));
            Functions.Add("concat", new FunctionInfo("concat", Types["string"], new List<Parameter> { new Parameter("s1", "string"), new Parameter("s2", "string") }));
            Functions.Add("not", new FunctionInfo("not", Types["int"], new List<Parameter> { new Parameter("i", "int") }));
            Functions.Add("exit", new FunctionInfo("exit", Types["void"],new List<Parameter> { new Parameter("i", "int") }));
            Functions.Add("getline", new FunctionInfo("getline", Types["string"], new List<Parameter> { }));
            Functions.Add("printline", new FunctionInfo("printline", Types["void"], new List<Parameter> { new Parameter("s", "string") }));

        }
        public VarInfo ExistVariable(string var)
        {
            VarInfo v = Variables.ContainsKey(var) ? Variables[var] : null;
            if (v != null) return v;
            if (parent != null) return parent.ExistVariable(var);
            return null;
        }
        public TypeInfo ExistType(string type)
        {
            TypeInfo t = Types.ContainsKey(type) ? Types[type] : null;
            if (t != null) return t;
            if (parent != null)
                return parent.ExistType(type);
            return null;
        }
        public FunctionInfo ExistFunctions(string function)
        {
            FunctionInfo f = Functions.ContainsKey(function) ? Functions[function] : null;
            if (f != null) return f;
            if (parent != null) return parent.ExistFunctions(function);
            return null;
        }
    }
}
