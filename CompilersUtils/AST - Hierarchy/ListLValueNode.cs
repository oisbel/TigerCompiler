using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class ListLValueNode:InstructionNode
    {
        public List<Access> Access { get; set; }
        public TigerNode Id { get; set; }
        public TigerNode lval;
        public ListLValueNode(TigerNode id,List<Access> access)
        {
            Id = id;
            Access = access;
            lval = null;
        }
        public void GetLValues(List<Access> access,ref TigerNode l)
        {
            if (access.Count() != 0)
            {
                if (access[0] is AccessArray)
                {
                    AccessArray elem_array = (AccessArray)access[0];
                    access.RemoveAt(0);
                    //LValueNode temp = l;
                    l = new ElemArrayNode(elem_array.Index, l);
                    GetLValues(access,ref l);
                }
                else
                {
                    AccessRecord field_record = (AccessRecord)access[0];
                    access.RemoveAt(0);
                    //LValueNode temp=l;
                    l = new FieldRecordNode(field_record.Field, l);
                    GetLValues(access,ref l);
                }
            }
            return;           
        }

        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            int count = errors.Count();
            Id.CheckSemantic(scope, errors);


            lval = (TigerNode)Id;
            GetLValues(Access, ref lval);

            count = errors.Count();
            lval.CheckSemantic(scope, errors);
            if (count == errors.Count())
                ReturnType = lval.ReturnType;
                        
        }

       

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            lval.GenCode(tb, mb, cg);
        }
    }
}
