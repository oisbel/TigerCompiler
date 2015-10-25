using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class ArrayNode:InstructionNode
    {
        public string Name { get; set; }
        public TigerNode Length { get; set; }
        public TigerNode Value { get; set; }

        public ArrayNode(string name, TigerNode length, TigerNode value)
        {
            Name = name; Length = length; Value = value;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            TypeInfo t = null;

            //compruebo que exista el tipo del array
            t = scope.ExistType(Name);

            //sino lanzo un error
            if (t == null)
                errors.Add(new Error(Row, Col, string.Format("Doesn't exist any type with name \"{0}\"", Name)));
            else if (!t.IsArray)
                errors.Add(new Error(Row, Col, string.Format("The type \"{0}\" isn't array", Name)));
            else
            {
                //chekea la semantica de la expr del length el array
                Length.CheckSemantic(scope, errors);
                if (Length.ReturnType != null && Length.ReturnType.BaseType.Name != "int")
                    errors.Add(new Error(Row, Col, "The type of length of array must be an int"));

                //chekea la semantica de la expr de rellenar el array
                Value.CheckSemantic(scope, errors);

                //compruebo que el valor para rellenar el array sea del mismo tipo que el base de este
                if (Value.ReturnType != null && t.Type.BaseType.Name != Value.ReturnType.BaseType.Name)
                {
                    if (Value.ReturnType.BaseType.Name == "nil")
                    {
                        if(t.BaseType.IsInt)
                            errors.Add(new Error(Row, Col, string.Format("The value to fill array cannot be <nil>", t.Type.Name)));
                    }
                    else 
                        errors.Add(new Error(Row, Col, string.Format("The value to fill array must be <{0}>", t.Type.Name)));
                }
            }
            ReturnType = t;
        }


        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            Type elementType;
            if (Value.ReturnType.Name == "nil")
                elementType = Compiler.SearchType(Name);
            else
                elementType = Compiler.SearchType(Value.ReturnType.Name);

            Type tipoArray = elementType.MakeArrayType();//int[]

            LocalBuilder array = cg.DeclareLocal(tipoArray);//int[]array
            Length.GenCode(tb, mb, cg);

            cg.Emit(OpCodes.Dup);
            cg.Emit(OpCodes.Newarr, elementType);//int[5]
            cg.Emit(OpCodes.Stloc, array);//array=int[5]

            LocalBuilder extremoIntervalo = cg.DeclareLocal(typeof(int));
            cg.Emit(OpCodes.Stloc, extremoIntervalo);//guarda el tamnno del array

            cg.BeginScope();//crea un nuevo scope que al final se cierrra
            LocalBuilder value = cg.DeclareLocal(elementType);

            //comienzo a llenar el array..es un for cuando lo desemsamblo
            System.Reflection.Emit.Label star = cg.DefineLabel();
            System.Reflection.Emit.Label end = cg.DefineLabel();

            LocalBuilder i = cg.DeclareLocal(typeof(int));
            cg.Emit(OpCodes.Ldc_I4_0);
            cg.Emit(OpCodes.Stloc, i);

            cg.MarkLabel(star);
            cg.Emit(OpCodes.Ldloc, i);
            cg.Emit(OpCodes.Ldloc, extremoIntervalo);
            cg.Emit(OpCodes.Bge, end);

            Value.GenCode(tb, mb, cg);
            cg.Emit(OpCodes.Stloc, value);

            cg.Emit(OpCodes.Ldloc, array);
            cg.Emit(OpCodes.Ldloc, i);
            cg.Emit(OpCodes.Ldloc, value);

          

            cg.Emit(OpCodes.Stelem, value.LocalType);

            

            cg.Emit(OpCodes.Ldc_I4_1);
            cg.Emit(OpCodes.Ldloc, i);
            cg.Emit(OpCodes.Add);
            cg.Emit(OpCodes.Stloc, i);
            cg.Emit(OpCodes.Br, star);

            cg.MarkLabel(end);

            cg.EndScope();
            cg.Emit(OpCodes.Ldloc, array);
        }
    }
}
