using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CompilersUtils;
namespace tiger
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("The program expected 1 argument");
                Console.ReadLine();
                return;
            }
            DirectoryInfo di = new DirectoryInfo(args[0]);
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("The path {0} is wrong", args[0]);
                Console.ReadLine();
                return;
            }
            string dir;
            Console.WriteLine("\n\nTiger Compiler version 1.0\n\n Copyright (C) 2011-2012 Oisbel Simpson & Danaice Lopez & Karla Iturriza\n\n");
            Compiler compiler = new Compiler();
            dir = args[0].ToString();
            //dir = "..\\..\\..\\tests\\Success\\str.tig";
            List<Error> errors = compiler.Compile(dir);
            if (errors.Count > 0)
            {
                Console.WriteLine("__________Errores_________\n");
                foreach (var item in errors)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("\n… código de salida de tiger.exe: 1");
            }
            else
            {
                string name = dir.Substring(dir.LastIndexOf("\\") + 1);
                string[] filename = name.Split('.');
                Console.WriteLine("… código de salida de tiger.exe: 0\n … y se crea (o sobrescribe) el archivo {0}", filename[0] + ".exe");
            }
            Console.ReadLine();
        }
    }
}
