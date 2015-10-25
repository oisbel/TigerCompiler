using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompilersUtils;
using System.IO;

namespace TestCompilerToTiger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void test_str()
        {
            string testName = "str1";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";
            //string outputBinary = "..\\..\\..\\tests\\Success";
            //SetDirectory(outputBinary);

            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test Failed ", testName);


        }
        public void SetDirectory(string outputBinary)
        {
            Directory.SetCurrentDirectory(outputBinary);
        }

        [TestMethod()]
        public void test_mod2()
        {
            string testName = "mod2";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Cannot declarate a type named <string>"),      
                                        new Error(0,0,"Cannot assisgn \"int\" to a variable of type \"string\""),                                 
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mod3()
        {
            string testName = "mod3";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Cannot create a function named \"print\""),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mod4()
        {
            string testName = "mod4";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");

        }

        [TestMethod()]
        public void test_mod5()
        {
            string testName = "mod5";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The type \"MyType\" is already defined in this scope"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mod6()
        {
            string testName = "mod6";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";

            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");

        }
        [TestMethod()]
        public void test_mod7_1()
        {
            string testName = "mod7_1";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The expression that try assign to \"int\" not return value"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mod7_2()
        {
            string testName = "mod7_2";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";

            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The expression that try assign to \"int\" not return value"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mod7_3()
        {
            string testName = "mod7_3";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The expression that try assign to \"int\" not return value"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mod8()
        {
            string testName = "mod8";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");

        }

        [TestMethod()]
        public void test_test1()
        {
            string testName = "test1";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test2()
        {
            string testName = "test2";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test3()
        {
            string testName = "test3";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test4()
        {
            string testName = "test4";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test5()
        {
            string testName = "test5";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test6()
        {
            string testName = "test6";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test7()
        {
            string testName = "test7";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test8()
        {
            string testName = "test8";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test9()
        {
            string testName = "test9";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The second and third expressions of <if-then-else> must be of the same type")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test Failed ", testName);


        }

        [TestMethod()]
        public void test_test10()
        {
            string testName = "test10";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(2,0,"The body's expression of <while> must not return a value")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test11()
        {
            string testName = "test11";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The To'expression of <for> must be an int"),
                                        new Error(0,0,"Cannot assign any value to variable \"i\" of <for>")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test12()
        {
            string testName = "test12";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test13()
        {
            string testName = "test13";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The left and rigth operand in \">\" operator may be either both <integer> or both <string>")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test14()
        {
            string testName = "test14";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The left and rigth operand in \"<>\" operator may be either of the same type")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test15()
        {
            string testName = "test15";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The body's expressions of <if-then> must not return a value")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test16()
        {
            string testName = "test16";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The type \"d\" do not not pass through record or array"),
                                        new Error(0,0,"The type \"c\" do not not pass through record or array"),
                                        new Error(0,0,"The type \"b\" do not not pass through record or array"),
                                        new Error(0,0,"The type \"a\" do not not pass through record or array"),
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test17()
        {
            string testName = "test17";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The type \"treelist\" is not defined"),
                                        new Error(0,0,"The type \"tree\" is not defined")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test18()
        {
            string testName = "test18";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Doesn't exist any function with name \"do_nothing2\""),
                                        new Error(0,0,"Doesn't exist any function with name \"do_nothing1\""),
                                        new Error(0,0,"Doesn't exist any function with name \"do_nothing1\"")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test19()
        {
            string testName = "test19";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The variable \"a\" doesn't exist in the current scope")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test21()
        {
            string testName = "test21";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The rigth operand in \"*\" operator must be return an int"),
                                        new Error(0,0,"The procedure \"nfactor\"cannot return any value"),
                                        new Error(0,0,"Doesn't exist any function with name \"nfactor\"")
                                        
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test22()
        {
            string testName = "test22";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The type \"rectype\" don't have any field \"nam\""),
                                     };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test23()
        {
            string testName = "test23";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Cannot asssign  \"int\" to  \"string\""), 
                                        new Error(0,0,"Cannot asssign  \"string\" to  \"int\"")                                        
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test24()
        {
            string testName = "test24";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Only can indexer to array type"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test25()
        {
            string testName = "test25";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The expression must be record type"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test26()
        {
            string testName = "test26";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The rigth operand in \"+\" operator must be return an int"),                                                                             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test27()
        {
            string testName = "test27";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test28()
        {
            string testName = "test28";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Cannot assisgn \"rectype2\" to a variable of type \"rectype1\""),
                                         new Error(0,0,"The variable \"rec1\" doesn't exist in the current scope")                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test29()
        {
            string testName = "test29";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Cannot assisgn \"arrtype2\" to a variable of type \"arrtype1\""),
                                         new Error(0,0,"The variable \"arr1\" doesn't exist in the current scope")                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test30()
        {
            string testName = "test30";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test31()
        {
            string testName = "test31";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Cannot assisgn \"string\" to a variable of type \"int\""),
                                        new Error(0,0,"The variable \"a\" doesn't exist in the current scope")                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test32()
        {
            string testName = "test32";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The value to fill array must be <int>"),
                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test33()
        {
            string testName = "test33";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"Doesn't exist any type with name \"rectype\""),
                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test34()
        {
            string testName = "test34";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The parameters \"1\" must be <int>"),
                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test35()
        {
            string testName = "test35";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                        new Error(0,0,"The function \"g\" don't receive 1 parameter(s)"),
                                        new Error(0,0,"The parameters \"1\" must be <int>")             
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test36()
        {
            string testName = "test36";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The function \"g\" don't receive 3 parameter(s)")                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test37()
        {
            string testName = "test37";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                       
                                        new Error(0,0,"The variable \"a\" is already exist in this scope")
                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test38()
        {
            string testName = "test38";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The type \"a\" is already defined in this scope")                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test39()
        {
            string testName = "test39";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Already exist a function named \"g\" in this block")                                                     
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test40()
        {
            string testName = "test40";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The procedure \"g\"cannot return any value"),    
                                        new Error(0,0,"Doesn't exist any function with name \"g\"")            
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test41()
        {
            string testName = "test41";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test42()
        {
            string testName = "test42";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test43()
        {
            string testName = "test43";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {
                new Error(0,0,"Cannot infer the type of the variable \"a\""),
                new Error(0,0,"The variable \"a\" doesn't exist in the current scope")
            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test44()
        {
            string testName = "test44";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test45()
        {
            string testName = "test45";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Cannot assign <nil> to a variable without explicit type"),
                                        new Error(0,0,"The variable \"a\" doesn't exist in the current scope")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test46()
        {
            string testName = "test46";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test47()
        {
            string testName = "test47";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The type \"a\" is already defined in this scope")
                                        
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_test48()
        {
            string testName = "test48";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The function \"g\" is already exist in this scope")
                                        
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        //tiene q dar un error en el parser
        [TestMethod()]
        public void test_test49()
        {
            string testName = "test49";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {
                new Error(0,0,"error del parser")
            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
           

        }

        [TestMethod()]
        public void test_test50()
        {
            string testName = "test50";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_and_operator_returns_value()
        {
            string testName = "and_operator_returns_value";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The body's expression of <while> must not return a value")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_break_in_a_function()
        {
            string testName = "break_in_a_function";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The break is illegal outside <for> or <while>"), 
                                        new Error(0,0,"The break is illegal outside <for> or <while>")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_break_out_of_for()
        {
            string testName = "break_out_of_for";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The break is illegal outside <for> or <while>"),                                         
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_break_out_of_while()
        {
            string testName = "break_out_of_while";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The break is illegal outside <for> or <while>"),                                         
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_divide_between_non_valued_right()
        {
            string testName = "divide_between_non_valued_right";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The rigth operand in \"+\" operator must be return an int"),                                         
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_expression_sequence_returns_last_value()
        {
            string testName = "expression_sequence_returns_last_value";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The condition's expressions of <if-then-else> must be an int"),
                                        new Error(0,0,"The second and third expressions of <if-then-else> must be of the same type")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_if_then_else_without_return_value()
        {
            string testName = "if_then_else_without_return_value";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The first expression of <while> must be an int")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_if_then_without_valued_condition()
        {
            string testName = "if_then_without_valued_condition";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The break is illegal outside <for> or <while>"),
                                        new Error(0,0,"The condition's expressions of <if-then> must be an int"),
                                        new Error(0,0,"The break is illegal outside <for> or <while>")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_inferred_variable_incompatibles_type()
        {
            string testName = "inferred_variable_incompatibles_type";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The left and rigth operand in \"=\" operator may be either of the same type"),
                                        new Error(0,0,"Cannot asssign  \"string\" to  \"int\""),
                                        new Error(0,0,"Cannot asssign  \"int\" to  \"string\"")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_invalid_mutually_recursive_function_depth_3()
        {
            string testName = "invalid_mutually_recursive_function_depth_3";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The type of parameter \"b\" is not defined"),                                       
                                        new Error(0,0,"Doesn't exist any function with name \"h\""),
                                        new Error(0,0,"Doesn't exist any function with name \"f\"")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_invalid_mutually_recursive_function_depth_4()
        {
            string testName = "invalid_mutually_recursive_function_depth_4";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The type of parameter \"b\" is not defined"),
                                        new Error(0,0,"Doesn't exist any function with name \"h\""),
                                        new Error(0,0,"Doesn't exist any function with name \"i\""),
                                        new Error(0,0,"Doesn't exist any function with name \"f\""),
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_invalid_mutually_recursive_record()
        {
            string testName = "invalid_mutually_recursive_record";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_array_string_nil()
        {
            string testName = "array_string_nil";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
        }

        [TestMethod()]
        public void test_array_init()
        {
            string testName = "array_init";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
        }

        [TestMethod()]
        public void test_access_complex()
        {
            string testName = "access_complex";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");

        }

        [TestMethod()]
        public void test_invalid_mutually_recursive_record_depth_3()
        {
            string testName = "invalid_mutually_recursive_record_depth_3";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                     {                                       
                                       new Error(0,0,"The type \"C\" is not defined")
                                     };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_invalid_mutually_recursive_record_depth_4()
        {
            string testName = "invalid_mutually_recursive_record_depth_4";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                     {                                       
                                       new Error(0,0,"The type \"C\" is not defined"),
                                       new Error(0,0,"The type \"H\" is not defined"),
                                       new Error(0,0,"The type \"C\" do not not pass through record or array"),
                                     };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_mutually_recursive_alias()
        {
            string testName = "mutually_recursive_alias";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The type \"d\" do not not pass through record or array"),
                                        new Error(0,0,"The type \"c\" do not not pass through record or array"),
                                        new Error(0,0,"The type \"b\" do not not pass through record or array"),
                                        new Error(0,0,"The type \"a\" do not not pass through record or array"),
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_nested_unavailable_function()
        {
            string testName = "nested_unavailable_function";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_procedure_same_parameters_name()
        {
            string testName = "procedure_same_parameters_name";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Cannot be 2 parameters with the same name"),
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_record_access_incompatibles_types()
        {
            string testName = "record_access_incompatibles_types";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Cannot asssign  \"human\" to  \"int\""),
                                        new Error(0,0,"The left and rigth operand in \"=\" operator may be either of the same type")                       
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_record_literal_invalid_types()
        {
            string testName = "record_literal_invalid_types";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Cannot assign <nil> to an <int>"),
                                        new Error(0,0,"The field \"siblin\" of record must be of type \"human\""),
                                        
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_record_literal_less_params()
        {
            string testName = "record_literal_less_params";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The record \"human\" don't have 1 parameter(s)")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_record_literal_more_params()
        {
            string testName = "record_literal_more_params";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The record \"human\" don't have 2 parameter(s)")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_recursive_array()
        {
            string testName = "recursive_array";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The array \"a\" can't be recursive")                                      
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_recursive_array_alias()
        {
            /*string testName = "recursive_array_alias";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";
            

            
            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);*/

        }

        [TestMethod()]
        public void test_undefined_type_for_alias()
        {
            string testName = "undefined_type_for_alias";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {   
                                        new Error(0,0,"The type \"non_defined\" is not defined"),
                                        new Error(0,0,"The type \"g\" do not not pass through record or array")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_undefined_type_for_array_declaration()
        {
            string testName = "undefined_type_for_array_declaration";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The type \"rectype\" is not defined in this scope")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_and_operator_invalid_type_operands()
        {
            string testName = "and_operator_invalid_type_operands";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The rigth operand in \"&\" operator must be return an int"), 
                                        new Error(0,0,"The left operand in \"&\" operator must be return an int"),
                                        new Error(0,0,"The left operand in \"&\" operator must be return an int"),
                                        new Error(0,0,"The rigth operand in \"&\" operator must be return an int")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_and_operator_non_valued_operands()
        {
            string testName = "and_operator_non_valued_operands";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"The rigth operand in \"&\" operator must be return an int"), 
                                        new Error(0,0,"The left operand in \"&\" operator must be return an int"),
                                        new Error(0,0,"The left operand in \"&\" operator must be return an int"),
                                        new Error(0,0,"The rigth operand in \"&\" operator must be return an int")
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_differents_types_array_assign()
        {
            string testName = "differents_types_array_assign";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Cannot asssign  \"arrayinteger\" to  \"arrayint\""),                                         
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        //ver porq no esta llegando el segundo indexer
        [TestMethod()]
        public void test_incompatible_types_jagged_array()
        {
            string testName = "incompatible_types_jagged_array";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
                                    {                                       
                                        new Error(0,0,"Cannot asssign  \"string\" to  \"int\"")                                       
                                    };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }

        [TestMethod()]
        public void test_queens()
        {
            string testName = "queens";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";



            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);

        }
        //ver con esta gente
        [TestMethod()]
        public void test_merge()
        {
            /*string testName = "merge";
            string inputProgram = "..\\..\\..\\tests\\" + testName + ".tig";
            

            
            Compiler compiler = new Compiler();
            compiler.Compile(inputProgram);
            List<Error> expected = new List<Error>()
            {

            };
            Assert.AreEqual(expected.Count, Compiler.Errors.Count, "El test " + testName + "la cantidad de errores fueron distintos");
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], Compiler.Errors[i], "{0} Test fallido ", testName);*/

        }

    }
}