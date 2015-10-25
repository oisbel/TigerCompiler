using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class ExprSeqNode:InstructionNode
    {
        public List<TigerNode> Exprs { get; set; }
        bool existbreak;

        public ExprSeqNode(List<TigerNode> exprs)
        {
            Exprs = exprs;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            TypeInfo t = null;
            for (int i = 0; i < Exprs.Count(); i++)
            {                
                Exprs[i].CheckSemantic(scope, errors);
                if (Exprs[i] is IBreakable)
                {
                    if (((IBreakable)Exprs[i]).HaveBreak)
                        existbreak = true;
                }
                if (i == Exprs.Count() - 1 )
                {
                    t = Exprs[i].ReturnType; 
                }
            }
            if (!existbreak)
            {
                ReturnType = (t == null) ? new TypeInfo("void", null, TypeDecl.Base) : t;
            }
            else
                ReturnType = new TypeInfo("void", null, TypeDecl.Base);
            
        }

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            for (int i = 0; i < Exprs.Count - 1; i++)
            {

                Exprs[i].GenCode(tb, mb, cg);
                if (Exprs[i].ReturnType.Name != "void")
                    cg.Emit(OpCodes.Pop);
            }
            Exprs[Exprs.Count - 1].GenCode(tb, mb, cg);
        }
    }
}
