using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;
using System.Reflection;
using System.Reflection.Emit;

namespace CompilersUtils
{
    public class Compiler
    {
        string inputpath;
        string dir;
        public AssemblyName name;
        public AssemblyBuilder asmBluider;
        public static ModuleBuilder moduleBuilder;
        public static TypeBuilder typeBuilder;

        static ANTLRFileStream stream;
        static tiger_grammarLexer lexer;
        static tiger_grammarParser parser;
        static CommonTokenStream tokens;
        public static List<Error> Errors = new List<Error>();

        public static List<TypeStack> Types;
        public static List<RecordsConstructors> RecordConstructors;
        public static List<VarStack> Variables;
        public static List<FuncStack> Functions;
        public static int LetCount;
        public static int ForCount;
        public static Dictionary<string, MethodBuilder> funciones;
        public static Stack<Label> ends = new Stack<Label>();
        public TigerNode root;
        public Compiler()
        {
            funciones = new Dictionary<string, MethodBuilder>();
        }

        public List<Error> Compile(string inputPath)
        {
            this.inputpath = inputPath;
            root = null;

            stream = new ANTLRFileStream(inputpath);
            lexer = new tiger_grammarLexer(stream);
            tokens = new CommonTokenStream(lexer);
            parser = new tiger_grammarParser(tokens);

            try
            {
                var result = parser.language();
                root = result;
                if (parser.Errors.Count() == 0)
                {
                    Errors.Clear();
                    Scope scope = new Scope(null);
                    scope.InitiScope();
                    root.CheckSemantic(scope, Errors);

                    if (Errors.Count() == 0)
                    {
                        GenCode(root);
                    }
                }
                else
                {
                    Errors.Clear();
                    foreach (var item in parser.Errors)
                    {
                        Errors.Add(new Error(0,0,item));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            return Errors;

        }

        public void Initialize()
        {
            string filename = inputpath.Substring(inputpath.LastIndexOf('\\') + 1);
            name = new AssemblyName(filename);
            asmBluider = AppDomain.CurrentDomain.DefineDynamicAssembly(name, AssemblyBuilderAccess.RunAndSave);
            string namef = filename.Split('.')[0];
            moduleBuilder = asmBluider.DefineDynamicModule(namef, namef + ".exe");
            
            typeBuilder = moduleBuilder.DefineType("Program", TypeAttributes.Public | TypeAttributes.Class);

            LetCount = 0;
            Types = new List<TypeStack>();
            Types.Add(new TypeStack("int", typeof(int)));
            Types.Add(new TypeStack("string", typeof(string)));
            Types.Add(new TypeStack("void", typeof(void))); 

            RecordConstructors = new List<RecordsConstructors>();
            Variables = new List<VarStack>();
            Functions = new List<FuncStack>();

        }

        public void GenCode(TigerNode root)
        {
            Initialize();
            if (root == null) throw new Exception(" Fatal Error");
            if (Errors.Count == 0)
            {
                GeneratePredefinitedFunction();
                MethodBuilder methodBuilder = typeBuilder.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static, typeof(void), Type.EmptyTypes);
                asmBluider.SetEntryPoint(methodBuilder, PEFileKinds.ConsoleApplication);
                ILGenerator cg = methodBuilder.GetILGenerator();

                root.GenCode(typeBuilder, methodBuilder, cg);

                if (root is InstructionNode && root.ReturnType.BaseType.Name != "void")
                {
                    cg.Emit(OpCodes.Pop);
                }
                cg.EmitWriteLine("\n The program finish successfully");
                cg.EmitWriteLine("\n Enter for to continue...");
                cg.EmitCall(OpCodes.Call, typeof(Console).GetMethod("ReadLine"), null);
                cg.Emit(OpCodes.Pop);
                cg.Emit(OpCodes.Ret);
                typeBuilder.CreateType();

                string filename = inputpath.Substring(inputpath.LastIndexOf('\\') + 1);
                string namef = filename.Split('.')[0];

                asmBluider.Save(namef + ".exe");

                System.Diagnostics.Process.Start(namef + ".exe");
            }
        }
        
        public static Type SearchType(string name)
        {
            for (int i = Types.Count - 1; i >= 0; i--)
                if (Types[i].name == name)
                    return Types[i].type;
            return null;
        }

        public void GeneratePredefinitedFunction()
        {
            ////Print
            MethodBuilder print = typeBuilder.DefineMethod("Write", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[] { typeof(string) });
            ILGenerator wg = print.GetILGenerator();
            wg.Emit(OpCodes.Ldarg_0);
            wg.EmitCall(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(string) }), null);
            wg.Emit(OpCodes.Ret);
            funciones.Add("print", print);

            ////Printint
            MethodBuilder printint = typeBuilder.DefineMethod("Write", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[] { typeof(int) });
            ILGenerator wintg = printint.GetILGenerator();
            wintg.Emit(OpCodes.Ldarg_0);
            wintg.EmitCall(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(int) }), null);
            wintg.Emit(OpCodes.Ret);
            funciones.Add("printint", printint);

            ////Concat
            MethodBuilder concat = typeBuilder.DefineMethod("Concat", MethodAttributes.Public | MethodAttributes.Static,
                                                            typeof(string), new Type[] { typeof(string), typeof(string) });
            ILGenerator ccg = concat.GetILGenerator();
            ccg.Emit(OpCodes.Ldarg_0);
            ccg.Emit(OpCodes.Ldarg_1);
            ccg.EmitCall(OpCodes.Call, typeof(String).GetMethod("Concat", new Type[] { typeof(string), typeof(string) }), null);
            ccg.Emit(OpCodes.Ret);
            funciones.Add("concat", concat);

            ////Printline
            MethodBuilder writeline = typeBuilder.DefineMethod("PrintLine", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[] { typeof(string) });
            ILGenerator wlg = writeline.GetILGenerator();
            wlg.Emit(OpCodes.Ldarg_0);
            wlg.EmitCall(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }), null);
            wlg.Emit(OpCodes.Ret);
            funciones.Add("printline", writeline);

            ////GetLine
            MethodBuilder getline = typeBuilder.DefineMethod("GetLine", MethodAttributes.Public | MethodAttributes.Static, typeof(string), new Type[0]);
            ILGenerator glg = getline.GetILGenerator();
            glg.EmitCall(OpCodes.Call, typeof(Console).GetMethod("ReadLine", new Type[0]), null);
            //glg.EmitCall(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }), null);
            glg.Emit(OpCodes.Ret);
            funciones.Add("getline", getline);

            ////Size
            MethodBuilder size = typeBuilder.DefineMethod("Size", MethodAttributes.Public | MethodAttributes.Static, typeof(int), new Type[] { typeof(string) });
            ILGenerator sg = size.GetILGenerator();
            sg.Emit(OpCodes.Ldarg_0);
            sg.Emit(OpCodes.Callvirt, typeof(String).GetProperty("Length").GetGetMethod());
            sg.Emit(OpCodes.Ret);
            funciones.Add("size", size);

            ////Not
            MethodBuilder notmethod = typeBuilder.DefineMethod("Notmethod", MethodAttributes.Public | MethodAttributes.Static, typeof(int), new Type[] { typeof(int) });
            ILGenerator notg = notmethod.GetILGenerator();
            notg.Emit(OpCodes.Ldarg_0);
            notg.Emit(OpCodes.Ldc_I4_0);
            Label one = notg.DefineLabel();
            notg.Emit(OpCodes.Beq, one);
            notg.Emit(OpCodes.Ldc_I4_0);
            Label fin = notg.DefineLabel();
            notg.Emit(OpCodes.Br, fin);
            notg.MarkLabel(one);
            notg.Emit(OpCodes.Ldc_I4_1);
            notg.MarkLabel(fin);
            notg.Emit(OpCodes.Ret);
            funciones.Add("not", notmethod);

            ////Substring
            MethodBuilder substring = typeBuilder.DefineMethod("Substring", MethodAttributes.Public | MethodAttributes.Static, typeof(string), new Type[] { typeof(string), typeof(int), typeof(int) });
            ILGenerator subg = substring.GetILGenerator();
            subg.Emit(OpCodes.Ldarg_0);
            subg.Emit(OpCodes.Ldarg_1);
            subg.Emit(OpCodes.Ldarg_2);
            subg.EmitCall(OpCodes.Callvirt, typeof(String).GetMethod("Substring", new Type[] { typeof(int), typeof(int) }), null);
            subg.Emit(OpCodes.Ret);
            funciones.Add("substring", substring);

            ////Exit
            MethodBuilder exit = typeBuilder.DefineMethod("Exit", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[] { typeof(int) });
            ILGenerator eg = exit.GetILGenerator();
            eg.Emit(OpCodes.Ldarg_0);
            eg.EmitCall(OpCodes.Call, typeof(Environment).GetMethod("Exit", new Type[] { typeof(int) }), null);
            eg.Emit(OpCodes.Ret);
            funciones.Add("exit", exit);

            ////Flush
            MethodBuilder flush = typeBuilder.DefineMethod("Flush", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[0]);
            ILGenerator fg = flush.GetILGenerator();
            fg.Emit(OpCodes.Call, typeof(Console).GetProperty("Out").GetGetMethod());
            fg.Emit(OpCodes.Callvirt, typeof(TextWriter).GetMethod("Flush"));
            fg.Emit(OpCodes.Ret);
            funciones.Add("flush", flush);

            ////////Ord
            MethodBuilder ordmethod = typeBuilder.DefineMethod("OrdMethod", MethodAttributes.Public | MethodAttributes.Static, typeof(int), new Type[] { typeof(string) });
            ILGenerator ordg = ordmethod.GetILGenerator();
            ordg.Emit(OpCodes.Ldarg_0);
            ordg.Emit(OpCodes.Ldstr, "");
            Label EMPTY = ordg.DefineLabel();
            ordg.Emit(OpCodes.Beq, EMPTY);
            // Dejar el valor del parámetro en la pila.
            ordg.Emit(OpCodes.Ldarg_0);
            ordg.Emit(OpCodes.Ldc_I4_0);
            ordg.Emit(OpCodes.Callvirt, typeof(String).GetMethod("get_Chars", new Type[] { typeof(int) }));
            ordg.Emit(OpCodes.Call, typeof(Convert).GetMethod("ToInt32", new Type[] { typeof(Char) }));
            Label END = ordg.DefineLabel();
            ordg.Emit(OpCodes.Br, END);
            ordg.MarkLabel(EMPTY);
            ordg.Emit(OpCodes.Ldc_I4_M1);
            ordg.MarkLabel(END);
            ordg.Emit(OpCodes.Ret);
            funciones.Add("ord", ordmethod);

            ////////Char
            MethodBuilder charmethod = typeBuilder.DefineMethod("OrdMethod", MethodAttributes.Public | MethodAttributes.Static, typeof(string), new Type[] { typeof(int) });
            ILGenerator chrg = charmethod.GetILGenerator();
            chrg.Emit(OpCodes.Ldarg_0);
            chrg.Emit(OpCodes.Ldc_I4, 49);
            Label empty = chrg.DefineLabel();
            chrg.Emit(OpCodes.Blt, empty);
            // Dejar el valor del parámetro en la pila.
            chrg.Emit(OpCodes.Ldarg_0);
            chrg.Emit(OpCodes.Ldc_I4, 122);
            chrg.Emit(OpCodes.Bgt, empty);
            // Dejar el valor del parámetro en la pila.
            chrg.Emit(OpCodes.Ldarg_0);
            chrg.Emit(OpCodes.Call, typeof(Convert).GetMethod("ToChar", new Type[] { typeof(int) }));
            chrg.Emit(OpCodes.Call, typeof(Convert).GetMethod("ToString", new Type[] { typeof(Char) }));
            Label end1 = chrg.DefineLabel();
            chrg.Emit(OpCodes.Br, end1);
            chrg.MarkLabel(empty);
            chrg.Emit(OpCodes.Ldstr, "");
            chrg.Emit(OpCodes.Ldc_I4_1);
            chrg.Emit(OpCodes.Call, typeof(Environment).GetMethod("Exit", new Type[] { typeof(int) }));
            chrg.MarkLabel(end1);
            chrg.Emit(OpCodes.Ret);
            funciones.Add("chr", charmethod);

            ////GetChar   
            MethodBuilder getchar = typeBuilder.DefineMethod("GetChar", MethodAttributes.Public | MethodAttributes.Static, typeof(string), new Type[0]);
            ILGenerator charg = getchar.GetILGenerator();
            charg.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadKey", new Type[0]));
            LocalBuilder charpress = charg.DeclareLocal(typeof(ConsoleKeyInfo));
            charg.Emit(OpCodes.Stloc, charpress);
            charg.Emit(OpCodes.Ldloca, charpress);
            charg.Emit(OpCodes.Call, typeof(ConsoleKeyInfo).GetProperty("KeyChar").GetGetMethod());
            charg.Emit(OpCodes.Call, typeof(Convert).GetMethod("ToString", new Type[] { typeof(Char) }));
            charg.Emit(OpCodes.Ret);
            funciones.Add("getchar", getchar);
            //////////
        }

        public static ConstructorBuilder SearchConstructorRecords(string name)
        {
            for (int i = RecordConstructors.Count - 1; i >= 0; i--)
                if (RecordConstructors[i].name == name)
                    return RecordConstructors[i].constructor;
            return null;
        }

        public static MethodBuilder SearchFunction(string name)
        {
            for (int i = Functions.Count - 1; i >= 0; i--)
                if (Functions[i].name == name)
                    return Functions[i].newFunction;
            return null;
        }

        public static FieldBuilder SearchVariable(string name)
        {
            for (int i = Variables.Count - 1; i >= 0; i--)
            {
                if (Variables[i].Id.Contains('_'))
                {
                    int len = Variables[i].Id.LastIndexOf('_') + 1;
                    string str = Variables[i].Id.Substring(len);
                    string str1 = Variables[i].Id.Substring(0, len - 1);
                    if (str == name || str1 == name)
                        return Variables[i].fb;
                }
                if (Variables[i].Id == name)
                    return Variables[i].fb;
            }
            return null;
        }

        public static List<VarStack> SearchParameterFunction(string funcName)
        {
            List<VarStack> result = new List<VarStack>();
            for (int i = 0; i < Variables.Count; i++)
                if (Variables[i].Id.StartsWith(funcName + "_"))
                    result.Add(Variables[i]);
            return result;
        }
    }
    public class TypeStack
    {
        public string name;
        public Type type;
        public string typeArray;

        public TypeStack(string name, Type type)
        {
            this.name = name;
            this.type = type;
        }

        public TypeStack(string name, Type type, string typeArray)
            : this(name, type)
        {
            this.typeArray = typeArray;
        }
    }

    public class VarStack
    {
        public FieldBuilder fb;
        public string Id;

        public VarStack(string id, FieldBuilder fb)
        {
            Id = id;
            this.fb = fb;
        }
    }

    public class RecordsConstructors
    {
        public ConstructorBuilder constructor;
        public string name;
        public RecordsConstructors(string name, ConstructorBuilder constructor)
        {
            this.constructor = constructor;
            this.name = name;
        }
    }

    public class FuncStack
    {
        public string name;
        public MethodBuilder newFunction;
        public FuncStack(string name, MethodBuilder newFunction)
        {
            this.name = name;
            this.newFunction = newFunction;
        }
    }
}
