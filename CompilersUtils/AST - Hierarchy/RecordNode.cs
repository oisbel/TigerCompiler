using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class RecordNode:InstructionNode
    {
        public string Name { get; set; }
        public List<string > Ids { get; set; }
        public List<TigerNode> Exprs { get; set; }

        public RecordNode(string name,List<string> ids,List<TigerNode> exprs)
        {
            Name = name;
            Ids = ids;
            Exprs = exprs;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            TypeInfo t = null;
            
            //busco el tipo en el scope
            t = scope.ExistType(Name);

            //si no existe lanzo un error
            if (t == null)
                errors.Add(new Error(Row, Col, string.Format("Doesn't exist any type with name \"{0}\"", Name)));
            //si existe pero no es de tipo record
            else if (!t.IsRecord)
                errors.Add(new Error(Row, Col, string.Format("The type {0} isn't record", Name)));
            else
            {
                //chekeo q tenga la misma cantidad de parametros
                if (Ids.Count() != t.Record_parameters.Count())
                    errors.Add(new Error(Row, Col,string.Format("The record \"{0}\" don't have {1} parameter(s)",Name,Ids.Count())));
                else
                {
                    //chekeo q los campos esten en el mismo orden
                    for (int i = 0; i < Ids.Count(); i++)
                    {
                        string field_name = t.Record_parameters[i].Id;
                        if (Ids[i] != field_name)
                            errors.Add(new Error(Row, Col, string.Format("The field name must be {0}", field_name)));
                    }
                    //chekeo q los valores de retorno de las expresiones
                    //sean del mismo tipo q su campo correspondiente en el record
                    for (int i = 0; i < Exprs.Count(); i++)
                    {
                        //chekeo la semantica de cada exprs
                        Exprs[i].CheckSemantic(scope, errors);
                        TypeInfo temp = scope.ExistType(t.Record_parameters[i].Type);
                        if (Exprs[i].ReturnType != null &&  temp.BaseType.Name != Exprs[i].ReturnType.BaseType.Name)
                        {
                            if (Exprs[i].ReturnType.BaseType.Name == "nil")
                            {
                                if(scope.ExistType(t.Record_parameters[i].Type).IsInt)
                                    errors.Add(new Error(Row, Col, string.Format("Cannot assign <nil> to an <int>")));
                            }
                            else
                                errors.Add(new Error(Row, Col, string.Format("The field \"{0}\" of record must be of type \"{1}\"",t.Record_parameters[i].Id, t.Record_parameters[i].Type)));
                        }
                            
                    }
                }
            }
            //actualizo el retorno del nodo
            ReturnType = t;
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            foreach (var item in Exprs)
                item.GenCode(tb, mb, cg);

            ConstructorBuilder constructor = Compiler.SearchConstructorRecords(Name);//porque sino no puedo crear otra instancia( si lo hiciera estatico

            cg.Emit(OpCodes.Newobj, constructor);
        }
    }
}
