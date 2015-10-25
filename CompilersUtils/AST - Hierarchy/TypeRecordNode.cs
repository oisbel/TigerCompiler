using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class TypeRecordNode:TypeDeclNode
    {
        public List<Parameter> Parameters { get; set; }
        public TypeRecordNode(string id,List<Parameter> parameters)
        {
            Id = id; Parameters = parameters;
        }
        public Type record;

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            //busco si hay un tipo con ese mismo nombre en el scope local
            TypeInfo t = scope.Types.ContainsKey(Id) ? scope.Types[Id] : null;
            int temp = errors.Count;
            if (Id == "string")
                errors.Add(new Error(Row, Col, string.Format("Cannot declarate a type named <string>")));
            if (Id == "int")
                errors.Add(new Error(Row, Col, string.Format("Cannot declarate a type named <int>")));
            //si ya esta definido lo agrego a los errors
            if (t != null)
                errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" is already defined in this scope", Id)));
            else 
            {
                foreach (Parameter p in Parameters)//veo si todos los campos del record son tipos definidos 
                {
                    TypeInfo t1 = scope.ExistType(p.Type);
                    if (t1 == null)
                    {
                        //busco si es alguno de mi bloque
                        bool exist = false;

                        foreach (var ty in scope.TempTypes)
                        {
                            if (ty.Id == p.Type) { exist = true; break; }
                        }                             
                        
                        if(!exist)
                            errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" is not defined", p.Type)));
                    }
                }
            }            
            
            if (temp == errors.Count)//si no hay errores
            {
                TypeInfo res = new TypeInfo(Id,null, TypeDecl.Record);
                res.Record_parameters = Parameters;
                scope.Types.Add(Id, res);
            }

            ReturnType = scope.ExistType("void");
        }

         public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            List<Type> parametersConstructor = new List<Type>();
            List<FieldBuilder> campos = new List<FieldBuilder>();

            foreach (var item in Parameters)
            {
                parametersConstructor.Add(Compiler.SearchType(item.Type));
                campos.Add(tb.DefineField(item.Id, Compiler.SearchType(item.Type), FieldAttributes.Public));
            }

            ConstructorBuilder constructor = tb.DefineConstructor(MethodAttributes.Public, CallingConventions.HasThis, parametersConstructor.ToArray());
            Compiler.RecordConstructors.Add(new RecordsConstructors(tb.Name, constructor));
            ILGenerator ilgen = constructor.GetILGenerator();

            Type objType = Type.GetType("System.Object");
            ConstructorInfo objCtor = objType.GetConstructor(new Type[0]);//creando el contructor vacio para generar el otro
            ilgen.Emit(OpCodes.Ldarg_0);
            ilgen.Emit(OpCodes.Call, objCtor);

            int i = 1;
            foreach (var item in campos)//poniendole los valores de los campos a lsa propiedades
            {
                ilgen.Emit(OpCodes.Ldarg_0);//este objeto ilgen=contructor.getIlgenerator()
                ilgen.Emit(OpCodes.Ldarg, i);//tiene un field item
                ilgen.Emit(OpCodes.Stfld, item);//y en el se pone el valor del argumento i del contructor
                i++;
            }
            ilgen.Emit(OpCodes.Ret);

            record = tb.CreateType();
        }
    }
}
