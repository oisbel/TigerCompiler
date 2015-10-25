using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;
namespace CompilersUtils
{
    public class LetNode : InstructionNode
    {
        public List<DeclarationNode> Declarations { get; set; }
        public List<TigerNode> Exprs { get; set; }

        public LetNode(List<DeclarationNode> declaratios, List<TigerNode> exprs)
        {
            Declarations = declaratios;
            Exprs = exprs;
        }
        public override void CheckSemantic(Scope scope, List<Error> errors)
        {
            int count = errors.Count();
            //inicializo el scope del let
            Scope letscope = new Scope(scope);

            //para guadar siempre la ultima declaracion
            DeclarationNode temp = null;
            //para guardar los bloques consecutivos de tipos y funciones
            List<TypeDeclNode> blockTypes = new List<TypeDeclNode>();
            List<FunctionDeclNode> blockFunctions = new List<FunctionDeclNode>();

            //guardo el primer decl
            if (Declarations.Count() != 0)
            {
                temp = Declarations[0];
                if (temp is FunctionDeclNode) blockFunctions.Add((FunctionDeclNode)temp);
                else if (temp is TypeDeclNode) blockTypes.Add((TypeDeclNode)temp);
                else temp.CheckSemantic(letscope, errors);
            }
            if (Declarations.Count() == 1)
            {
                if (temp is TypeDeclNode)
                {
                    CheckSemanticBlockTypes(blockTypes, letscope, errors);
                    blockTypes = new List<TypeDeclNode>();
                }
                else
                {
                    CheckSemanticBlockFunctions(blockFunctions, letscope, errors);
                    blockFunctions = new List<FunctionDeclNode>();
                }
            }


            //recorro las declaraciones y voy rellenando las listas
            //en dependencia del tipo de delaracion
            for (int i = 1; i < Declarations.Count(); i++)
            {
                if (Declarations[i] is TypeDeclNode)
                {
                    blockTypes.Add((TypeDeclNode)Declarations[i]);
                    if (temp is FunctionDeclNode)
                    {
                        CheckSemanticBlockFunctions(blockFunctions, letscope, errors);
                        blockFunctions = new List<FunctionDeclNode>();
                    }
                }
                else if (Declarations[i] is FunctionDeclNode)
                {
                    blockFunctions.Add((FunctionDeclNode)Declarations[i]);
                    if (temp is TypeDeclNode)
                    {
                        CheckSemanticBlockTypes(blockTypes, letscope, errors);
                        blockTypes = new List<TypeDeclNode>();
                    }
                }
                else //(Declarations[i] is VariableDeclNode)
                {
                    if (temp is TypeDeclNode)
                    {
                        CheckSemanticBlockTypes(blockTypes, letscope, errors);
                        blockTypes = new List<TypeDeclNode>();
                    }
                    if (temp is FunctionDeclNode)
                    {
                        CheckSemanticBlockFunctions(blockFunctions, letscope, errors);
                        blockFunctions = new List<FunctionDeclNode>();
                    }
                    Declarations[i].CheckSemantic(letscope, errors);
                }
                temp = Declarations[i];
            }
            if (blockFunctions.Count() > 0)
            {
                CheckSemanticBlockFunctions(blockFunctions, letscope, errors);
            }
            if (blockTypes.Count() > 0)
            {
                CheckSemanticBlockTypes(blockTypes, letscope, errors);
            }
            TypeInfo t = null;
            //chequeo la semantica de las expresiones
            //en la seccion in-end si existe alguna
            if (Exprs.Count() > 0)
            {
                for (int i = 0; i < Exprs.Count() - 1; i++)
                {
                    Exprs[i].CheckSemantic(letscope, errors);
                }
                //chekeo la semantica de la ultima expresion y si 
                //no tiene errores pongo su tipo de retorno como tipo de retorno del let
                int aux = errors.Count();
                Exprs[Exprs.Count() - 1].CheckSemantic(letscope, errors);
                if (aux == errors.Count())
                    t = Exprs[Exprs.Count() - 1].ReturnType;
            }

            //actualizo el tipo de retorno del nodo
            if (t != null) ReturnType = t;
            else ReturnType = new TypeInfo("void", null, TypeDecl.Base);

        }

        //chekeo la semantica de las declaraciones de tipo
        //en dependencia de si es un bloque o no
        void CheckSemanticBlockTypes(List<TypeDeclNode> blockTypes, Scope scope, List<Error> errors)
        {
            TypesBlockNode block_t = new TypesBlockNode(blockTypes);
            block_t.CheckSemantic(scope, errors);
        }
        //chekeo la semantica de las declaraciones de funciones
        //en dependencia de si es un bloque o no
        void CheckSemanticBlockFunctions(List<FunctionDeclNode> blockFunctions, Scope scope, List<Error> errors)
        {
            FunctionsBlockNode block_f = new FunctionsBlockNode(blockFunctions);
            block_f.CheckSemantic(scope, errors);
        }


        public override void GenCode(TypeBuilder tb, MethodBuilder mb, ILGenerator cg)
        {
            TypeBuilder LetClass = Compiler.moduleBuilder.DefineType("Let" + Compiler.LetCount.ToString(), TypeAttributes.Class | TypeAttributes.Public);
            Compiler.LetCount++;//crea la clase let#
            Type typeReturn = typeof(void);
            //if (Exprs.Count > 0)
            //{
            //    typeReturn = Compiler.SearchType(Exprs[Exprs.Count - 1].ReturnType.BaseType.Name);
            //}
            MethodBuilder BodyLet = LetClass.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static, typeReturn, new Type[] { });//crea el metodo principal main
            ILGenerator cgBody = BodyLet.GetILGenerator();
            //Declaraciones
            #region Declaraciones
            List<TypeBuilder> Records = new List<TypeBuilder>();
            int countTypes = 0;
            int countVars = 0;
            int countFunc = 0;
            int i = 0;

            while (i < Declarations.Count)
            {
                if (Declarations[i] is VariableDeclNode)//var
                {
                    Declarations[i].GenCode(LetClass, BodyLet, cgBody);//crear el fieldbuilder de la var en letclass y guardarlo en Compiler.Variables
                    countVars++;
                    i++;
                }
                else if (Declarations[i] is FunctionDeclNode)//Func
                {
                    List<FunctionDeclNode> func = new List<FunctionDeclNode>();//para guardar el bloque de func
                    while (i < Declarations.Count && Declarations[i] is FunctionDeclNode)
                    {
                        func.Add(Declarations[i] as FunctionDeclNode);
                        countFunc++;
                        i++;
                    }
                    //crear los methobuilder de las funciones por si hay un llamdo a func que no se ha declarado aun, y poner 
                    //los parametros como variables globales de la forma idfunc_nameparametro
                    for (int j = 0; j < func.Count; j++)
                    {
                        Type typeRet = Compiler.SearchType(func[j].IdType);
                        MethodBuilder newFunction = LetClass.DefineMethod(func[j].IdFunction, MethodAttributes.Static | MethodAttributes.Public, typeRet, new Type[] { });
                        Compiler.Functions.Add(new FuncStack(func[j].IdFunction, newFunction));

                        foreach (var item in func[j].Parameters)//haciendo a los parametros variables globales para que cuando se llame al funcion cojer y darle valor a las variables y llamar a la funcion
                        {
                            FieldBuilder fb = LetClass.DefineField(func[j].IdFunction + "_" + item.Id, Compiler.SearchType(item.Type), FieldAttributes.Public | FieldAttributes.Static);
                            Compiler.Variables.Add(new VarStack(func[j].IdFunction + "_" + item.Id, fb));
                        }
                    }
                    //genero el codigo de las funciones
                    foreach (var item in func)
                    {
                        item.GenCode(LetClass, BodyLet, cgBody);
                    }
                }
                else if (Declarations[i] is TypeDeclNode)//Types
                {
                    List<TypeRecordNode> records = new List<TypeRecordNode>();
                    List<TypeAliasNode> alias = new List<TypeAliasNode>();
                    List<TypeArrayNode> arrays = new List<TypeArrayNode>();

                    //guardar el bloque de type separados
                    while (i < Declarations.Count && Declarations[i] is TypeDeclNode)
                    {
                        if (Declarations[i] is TypeRecordNode)
                            records.Add(Declarations[i] as TypeRecordNode);

                        else if (Declarations[i] is TypeAliasNode)
                            alias.Add(Declarations[i] as TypeAliasNode);

                        else if (Declarations[i] is TypeArrayNode)
                            arrays.Add(Declarations[i] as TypeArrayNode);

                        countTypes++;
                        i++;
                    }
                    //crear las clases de los records y guardarloen Types
                    for (int j = 0; j < records.Count; j++)
                    {
                        TypeBuilder recordBuilder = Compiler.moduleBuilder.DefineType(records[j].Id, TypeAttributes.Public | TypeAttributes.Class);
                        Records.Add(recordBuilder);
                        Compiler.Types.Add(new TypeStack(records[j].Id, recordBuilder));

                    }
                    //primero genero el codig de los array porque no me importa de lo que es...en su creacion(en var) es que le pongo el tipo
                    for (int j = 0; j < arrays.Count; j++)
                        arrays[j].GenCode(LetClass, BodyLet, cgBody);
                    //despues alias porque no importa el tipo del que l;o quiero crear poruqe ya estan declarados todos los tipos
                    for (int j = 0; j < alias.Count; j++)
                        alias[j].GenCode(LetClass, BodyLet, cgBody);
                    //generar el cuerpo de la clase del record
                    for (int j = 0; j < records.Count; j++)
                        records[j].GenCode((TypeBuilder)Compiler.SearchType(records[j].Id), mb, cg);

                }
            }

            #endregion

            cg.EmitCall(OpCodes.Call, BodyLet, null);
            //genero codigo de las expresiones del cuerpo del metodo
            for (int j = 0; j < Exprs.Count - 1; j++)
            {
                Exprs[j].GenCode(tb,mb,cg);
                if (Exprs[j].ReturnType.Name != "void")
                    cg.Emit(OpCodes.Pop);
            }
            if (Exprs.Count > 0)
            {
                Exprs[Exprs.Count - 1].GenCode(tb, mb, cg);
            }


            cgBody.Emit(OpCodes.Ret);
            LetClass.CreateType();
           

            foreach (var item in Records)
                item.CreateType();//crear las clases de los records

            for (int j = 0; j < countVars; j++)
                Compiler.Variables.RemoveAt(Compiler.Variables.Count - 1);//quito la variables de ese scope
            for (int j = 0; j < countFunc; j++)
                Compiler.Functions.RemoveAt(Compiler.Functions.Count - 1);//lo mismo con las funciones 
            for (int j = 0; j < countTypes; j++)
                Compiler.Types.RemoveAt(Compiler.Types.Count - 1);//y con los tipos
        }
    }
}
