using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class ElemArrayNode:LValueNode
    {
        public TigerNode Expr { get; set; }
        public TigerNode Index { get; set; }

        public ElemArrayNode(TigerNode index, TigerNode expr)
        {
            Expr = expr; Index = index;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            //chekeo la semantica de expr   
            Expr.CheckSemantic(scope, errors);

            //compruebo q la var sea de tipo array
            if (Expr.ReturnType!= null && Expr.ReturnType.typedecl != TypeDecl.Array)
                errors.Add(new Error(Row, Col, string.Format("Only can indexer to array type")));
            else
            {
                //chekeo la semantica de index
                Index.CheckSemantic(scope, errors);

                //compruebo que el tipo de retorno de index sea int   
                if ( Index.ReturnType != null && Index.ReturnType.BaseType.Name != "int")
                    errors.Add(new Error(Row, Col, string.Format("The index must be return an int")));
            }

            //actualizo el tipo de retorno del nodo
            ReturnType = Expr.ReturnType.Type;
        }

       
        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            Type type = Type.EmptyTypes.GetType();

            for (int i = 0; i < Compiler.Types.Count; i++)
                if (Compiler.Types[i].name == Expr.ReturnType.Name)
                    type = Compiler.SearchType(Compiler.Types[i].typeArray);

            if (assign)
            {
                assign = false;
                LocalBuilder local = cg.DeclareLocal(type);
                cg.Emit(OpCodes.Stloc, local);
                Expr.GenCode(tb, mb, cg);//pone el array, luego el index y luego el valor para hacer stelem
                Index.GenCode(tb, mb, cg);
                cg.Emit(OpCodes.Ldloc, local);
                cg.Emit(OpCodes.Stelem, type);
            }
            else
            {
                Expr.GenCode(tb, mb, cg);
                Index.GenCode(tb, mb, cg);
                cg.Emit(OpCodes.Ldelem, type);
            }
            
        }
    }
}
