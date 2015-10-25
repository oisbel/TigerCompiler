using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
namespace CompilersUtils
{
    public class ForNode:ControlNode
    {
        public TigerNode ExprFor { get; set; }
        public TigerNode ExprTo { get; set; }
        public TigerNode ExprDo { get; set; }
        public string IdLoop { get; set; }

        public ForNode(string idLoop,TigerNode exprFor, TigerNode exprTo, TigerNode exprDo)
        {
            ExprFor = exprFor; ExprTo = exprTo; ExprDo = exprDo; IdLoop = idLoop;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            countLoop++;
            //chekeo la semantica de la expr inicial
            ExprFor.CheckSemantic(scope, errors);

            //si el tipo de retorno no es int lanzo un error
            if (ExprFor.ReturnType!= null && ExprFor.ReturnType.BaseType.Name != "int")
                errors.Add(new Error(Row, Col, "The first expression of <for> must be an int"));


            //chekeo la semantica de la expr final
            ExprTo.CheckSemantic(scope, errors);
            //si no tiene errores esa expr

            //si el tipo de retorno no es int lanzo un error
            if (ExprTo.ReturnType != null && ExprTo.ReturnType.BaseType.Name != "int")
                errors.Add(new Error(Row, Col, "The To'expression of <for> must be an int"));


            //creo un nuevo scope
            Scope for_scope = new Scope(scope);
            //agrego la var de ciclo
            for_scope.Variables.Add(IdLoop, new VarInfo(IdLoop, scope.ExistType("int")));       
            
            for_scope.IdLoop = IdLoop;

            ExprDo.CheckSemantic(for_scope, errors);

            ReturnType = new TypeInfo("void", null, TypeDecl.Base);
            countLoop--;
        }

        

        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            //i=exprFor
            FieldBuilder i = tb.DefineField(IdLoop + "_" + Compiler.ForCount, typeof(int), FieldAttributes.Public | FieldAttributes.Static);
            ExprFor.GenCode(tb, mb, cg);
            cg.Emit(OpCodes.Stsfld, i);
            Compiler.Variables.Add(new VarStack(IdLoop + "_" + Compiler.ForCount++, i));

            //guardo el n
            LocalBuilder to = cg.DeclareLocal(typeof(int));
            ExprTo.GenCode(tb,mb,cg);
            cg.Emit(OpCodes.Stloc,to);
            
            //marcar el inicio            
            Label start=cg.DefineLabel();
            Label end=cg.DefineLabel();
            Compiler.ends.Push(end);

            cg.MarkLabel(start);
            //saltar si el i=n
            cg.Emit(OpCodes.Ldsfld,i);
            cg.Emit(OpCodes.Ldloc,to);
            cg.Emit(OpCodes.Beq,end);
            //ejecuto exprDo
            ExprDo.GenCode(tb,mb,cg);

            //i++
            cg.Emit(OpCodes.Ldsfld,i);
            cg.Emit(OpCodes.Ldc_I4_1);
            cg.Emit(OpCodes.Add);
            cg.Emit(OpCodes.Stsfld, i);

            //salto al inicio
            cg.Emit(OpCodes.Br,start);

            cg.MarkLabel(end);
            Compiler.ends.Pop();
            //LocalBuilder i = cg.DeclareLocal(typeof(int));
            //////aqui viene exprvar.gencode
            //cg.Emit(OpCodes.Stloc, i);
            ////// aqui exprto.gencode
            ////FieldBuilder to = type.DefineField("to", typeof(int), FieldAttributes.Public);
            //LocalBuilder to = cg.DeclareLocal(typeof(int));
            //cg.Emit(OpCodes.Stloc, to);
            //cg.Emit(OpCodes.Ldloc, i);
            //cg.Emit(OpCodes.Ldloc, to);
            ////// 
            //Label iniciofor = cg.DefineLabel();
            //cg.MarkLabel(iniciofor);
            //Label endfor = cg.DefineLabel();
            //Compiler.ends.Push(endfor);
            //cg.Emit(OpCodes.Beq, endfor);     ///compara i con to
            //////aqui es donde va expr.gencode
            //ExprDo.GenCode(tb, mb, cg);
            ///////hasta aqui se borra
            //cg.Emit(OpCodes.Ldloc, i);
            //cg.Emit(OpCodes.Ldc_I4_1);
            //cg.Emit(OpCodes.Add);

            //cg.Emit(OpCodes.Stloc, i);
            //cg.Emit(OpCodes.Ldloc, i);
            //cg.Emit(OpCodes.Ldloc, to);
            //cg.Emit(OpCodes.Br, iniciofor);
            //cg.MarkLabel(endfor);
            //Compiler.ends.Pop();
        }
    }
}
