# TigerCompiler

Compiler for the programming language Tiger.
The Compiler generates IL code and have 3 phases:

1- Sintactic Analysis 2- Semantics Analysis 3- Code Generation

The first phase was implemented using the tool ANTLR. This tool generate a Lexer and a Parser using a grammar described. The second and third phases was implemented in C#.

The folder "tests" contains programs in programming language Tiger with extensions ".tig", the programs result are put in the folder "TestResults".

The compiler expects the full path of the file with extension ".tig" you want to compile. -If the file has semantic or semantic errors the compiler displays them, otherwise, the compiler generate a file .exe.
