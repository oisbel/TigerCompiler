// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g 2009-03-12 13:18:40


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class tiger_grammarLexer : Lexer {
    public const int FUNCTION = 43;
    public const int WHILE = 32;
    public const int COR_A = 22;
    public const int MENOS = 5;
    public const int COR_C = 23;
    public const int MENOR = 10;
    public const int CHAR = 47;
    public const int FOR = 34;
    public const int DO = 33;
    public const int AND = 27;
    public const int ID = 46;
    public const int EOF = -1;
    public const int BREAK = 36;
    public const int TYPE = 40;
    public const int IF = 29;
    public const int STR = 44;
    public const int THEN = 30;
    public const int IN = 38;
    public const int COMENTARIO = 50;
    public const int PAR_A = 19;
    public const int VAR = 41;
    public const int MAYIG = 14;
    public const int PAR_C = 20;
    public const int DIGIT = 48;
    public const int ARRAY = 42;
    public const int TO = 35;
    public const int ELSE = 31;
    public const int DIST = 12;
    public const int WHITESPACE = 49;
    public const int INT = 45;
    public const int LLAV_A = 24;
    public const int MULT = 6;
    public const int PTO = 15;
    public const int COMA = 21;
    public const int OF = 28;
    public const int LLAV_C = 25;
    public const int PTOCOM = 18;
    public const int NIL = 17;
    public const int DOSPTO = 16;
    public const int MAS = 4;
    public const int OR = 26;
    public const int MAYOR = 11;
    public const int ASIG = 8;
    public const int MENIG = 13;
    public const int IGUAL = 9;
    public const int DIV = 7;
    public const int END = 39;
    public const int LET = 37;

    // delegates
    // delegators

    public tiger_grammarLexer() 
    {
		InitializeCyclicDFAs();
    }
    public tiger_grammarLexer(ICharStream input)
		: this(input, null) {
    }
    public tiger_grammarLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g";} 
    }

    // $ANTLR start "MAS"
    public void mMAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:7:5: ( '+' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:7:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAS"

    // $ANTLR start "MENOS"
    public void mMENOS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MENOS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:8:7: ( '-' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:8:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MENOS"

    // $ANTLR start "MULT"
    public void mMULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:9:6: ( '*' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:9:8: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULT"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:10:5: ( '/' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:10:7: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "ASIG"
    public void mASIG() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASIG;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:11:6: ( ':=' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:11:8: ':='
            {
            	Match(":="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASIG"

    // $ANTLR start "IGUAL"
    public void mIGUAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IGUAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:12:7: ( '=' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:12:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IGUAL"

    // $ANTLR start "MENOR"
    public void mMENOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MENOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:13:7: ( '<' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:13:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MENOR"

    // $ANTLR start "MAYOR"
    public void mMAYOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAYOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:14:7: ( '>' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:14:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAYOR"

    // $ANTLR start "DIST"
    public void mDIST() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIST;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:15:6: ( '<>' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:15:8: '<>'
            {
            	Match("<>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIST"

    // $ANTLR start "MENIG"
    public void mMENIG() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MENIG;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:16:7: ( '<=' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:16:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MENIG"

    // $ANTLR start "MAYIG"
    public void mMAYIG() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAYIG;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:17:7: ( '>=' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:17:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAYIG"

    // $ANTLR start "PTO"
    public void mPTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PTO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:18:5: ( '.' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:18:7: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PTO"

    // $ANTLR start "DOSPTO"
    public void mDOSPTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOSPTO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:19:8: ( ':' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:19:10: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOSPTO"

    // $ANTLR start "NIL"
    public void mNIL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NIL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:20:5: ( 'nil' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:20:7: 'nil'
            {
            	Match("nil"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NIL"

    // $ANTLR start "PTOCOM"
    public void mPTOCOM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PTOCOM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:21:8: ( ';' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:21:10: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PTOCOM"

    // $ANTLR start "PAR_A"
    public void mPAR_A() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PAR_A;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:22:7: ( '(' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:22:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PAR_A"

    // $ANTLR start "PAR_C"
    public void mPAR_C() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PAR_C;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:23:7: ( ')' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:23:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PAR_C"

    // $ANTLR start "COMA"
    public void mCOMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:24:6: ( ',' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:24:8: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMA"

    // $ANTLR start "COR_A"
    public void mCOR_A() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COR_A;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:25:7: ( '[' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:25:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COR_A"

    // $ANTLR start "COR_C"
    public void mCOR_C() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COR_C;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:26:7: ( ']' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:26:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COR_C"

    // $ANTLR start "LLAV_A"
    public void mLLAV_A() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LLAV_A;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:27:8: ( '{' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:27:10: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LLAV_A"

    // $ANTLR start "LLAV_C"
    public void mLLAV_C() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LLAV_C;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:28:8: ( '}' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:28:10: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LLAV_C"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:29:4: ( '|' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:29:6: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:30:5: ( '&' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:30:7: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OF"
    public void mOF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:31:4: ( 'of' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:31:6: 'of'
            {
            	Match("of"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OF"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:32:4: ( 'if' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:32:6: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "THEN"
    public void mTHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:33:6: ( 'then' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:33:8: 'then'
            {
            	Match("then"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THEN"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:34:6: ( 'else' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:34:8: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:35:7: ( 'while' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:35:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "DO"
    public void mDO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:36:4: ( 'do' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:36:6: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DO"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:37:5: ( 'for' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:37:7: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "TO"
    public void mTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:38:4: ( 'to' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:38:6: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TO"

    // $ANTLR start "BREAK"
    public void mBREAK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BREAK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:39:7: ( 'break' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:39:9: 'break'
            {
            	Match("break"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BREAK"

    // $ANTLR start "LET"
    public void mLET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:40:5: ( 'let' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:40:7: 'let'
            {
            	Match("let"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LET"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:41:4: ( 'in' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:41:6: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:42:5: ( 'end' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:42:7: 'end'
            {
            	Match("end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "TYPE"
    public void mTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:43:6: ( 'type' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:43:8: 'type'
            {
            	Match("type"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TYPE"

    // $ANTLR start "VAR"
    public void mVAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:44:5: ( 'var' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:44:7: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VAR"

    // $ANTLR start "ARRAY"
    public void mARRAY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARRAY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:45:7: ( 'array' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:45:9: 'array'
            {
            	Match("array"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARRAY"

    // $ANTLR start "FUNCTION"
    public void mFUNCTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FUNCTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:46:10: ( 'function' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:46:12: 'function'
            {
            	Match("function"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FUNCTION"

    // $ANTLR start "STR"
    public void mSTR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:4: ( '\"' ( CHAR | INT | '+' | '*' | ';' | '#' | '@' | '\\t' | ':' | '\\ooooc' | '%' | '\\r' | '\\n' | '_' | '/' | '\\\\' | '>' | ',' | '!' | '$' | '(' | ')' | '=' | ']' | '[' | '.' | '<' | '-' | '&' | ' ' )* '\"' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:6: '\"' ( CHAR | INT | '+' | '*' | ';' | '#' | '@' | '\\t' | ':' | '\\ooooc' | '%' | '\\r' | '\\n' | '_' | '/' | '\\\\' | '>' | ',' | '!' | '$' | '(' | ')' | '=' | ']' | '[' | '.' | '<' | '-' | '&' | ' ' )* '\"'
            {
            	Match('\"'); 
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:9: ( CHAR | INT | '+' | '*' | ';' | '#' | '@' | '\\t' | ':' | '\\ooooc' | '%' | '\\r' | '\\n' | '_' | '/' | '\\\\' | '>' | ',' | '!' | '$' | '(' | ')' | '=' | ']' | '[' | '.' | '<' | '-' | '&' | ' ' )*
            	do 
            	{
            	    int alt1 = 31;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 'A':
            	    case 'B':
            	    case 'C':
            	    case 'D':
            	    case 'E':
            	    case 'F':
            	    case 'G':
            	    case 'H':
            	    case 'I':
            	    case 'J':
            	    case 'K':
            	    case 'L':
            	    case 'M':
            	    case 'N':
            	    case 'O':
            	    case 'P':
            	    case 'Q':
            	    case 'R':
            	    case 'S':
            	    case 'T':
            	    case 'U':
            	    case 'V':
            	    case 'W':
            	    case 'X':
            	    case 'Y':
            	    case 'Z':
            	    case 'a':
            	    case 'b':
            	    case 'c':
            	    case 'd':
            	    case 'e':
            	    case 'f':
            	    case 'g':
            	    case 'h':
            	    case 'i':
            	    case 'j':
            	    case 'k':
            	    case 'l':
            	    case 'm':
            	    case 'n':
            	    case 'o':
            	    case 'p':
            	    case 'q':
            	    case 'r':
            	    case 's':
            	    case 't':
            	    case 'u':
            	    case 'v':
            	    case 'w':
            	    case 'x':
            	    case 'y':
            	    case 'z':
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case '0':
            	    case '1':
            	    case '2':
            	    case '3':
            	    case '4':
            	    case '5':
            	    case '6':
            	    case '7':
            	    case '8':
            	    case '9':
            	    	{
            	        alt1 = 2;
            	        }
            	        break;
            	    case '+':
            	    	{
            	        alt1 = 3;
            	        }
            	        break;
            	    case '*':
            	    	{
            	        alt1 = 4;
            	        }
            	        break;
            	    case ';':
            	    	{
            	        alt1 = 5;
            	        }
            	        break;
            	    case '#':
            	    	{
            	        alt1 = 6;
            	        }
            	        break;
            	    case '@':
            	    	{
            	        alt1 = 7;
            	        }
            	        break;
            	    case '\t':
            	    	{
            	        alt1 = 8;
            	        }
            	        break;
            	    case ':':
            	    	{
            	        alt1 = 9;
            	        }
            	        break;
            	    case '\u0000':
            	    	{
            	        alt1 = 10;
            	        }
            	        break;
            	    case '%':
            	    	{
            	        alt1 = 11;
            	        }
            	        break;
            	    case '\r':
            	    	{
            	        alt1 = 12;
            	        }
            	        break;
            	    case '\n':
            	    	{
            	        alt1 = 13;
            	        }
            	        break;
            	    case '_':
            	    	{
            	        alt1 = 14;
            	        }
            	        break;
            	    case '/':
            	    	{
            	        alt1 = 15;
            	        }
            	        break;
            	    case '\\':
            	    	{
            	        alt1 = 16;
            	        }
            	        break;
            	    case '>':
            	    	{
            	        alt1 = 17;
            	        }
            	        break;
            	    case ',':
            	    	{
            	        alt1 = 18;
            	        }
            	        break;
            	    case '!':
            	    	{
            	        alt1 = 19;
            	        }
            	        break;
            	    case '$':
            	    	{
            	        alt1 = 20;
            	        }
            	        break;
            	    case '(':
            	    	{
            	        alt1 = 21;
            	        }
            	        break;
            	    case ')':
            	    	{
            	        alt1 = 22;
            	        }
            	        break;
            	    case '=':
            	    	{
            	        alt1 = 23;
            	        }
            	        break;
            	    case ']':
            	    	{
            	        alt1 = 24;
            	        }
            	        break;
            	    case '[':
            	    	{
            	        alt1 = 25;
            	        }
            	        break;
            	    case '.':
            	    	{
            	        alt1 = 26;
            	        }
            	        break;
            	    case '<':
            	    	{
            	        alt1 = 27;
            	        }
            	        break;
            	    case '-':
            	    	{
            	        alt1 = 28;
            	        }
            	        break;
            	    case '&':
            	    	{
            	        alt1 = 29;
            	        }
            	        break;
            	    case ' ':
            	    	{
            	        alt1 = 30;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:11: CHAR
            			    {
            			    	mCHAR(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:16: INT
            			    {
            			    	mINT(); 

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:20: '+'
            			    {
            			    	Match('+'); 

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:24: '*'
            			    {
            			    	Match('*'); 

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:28: ';'
            			    {
            			    	Match(';'); 

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:33: '#'
            			    {
            			    	Match('#'); 

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:37: '@'
            			    {
            			    	Match('@'); 

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:41: '\\t'
            			    {
            			    	Match('\t'); 

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:46: ':'
            			    {
            			    	Match(':'); 

            			    }
            			    break;
            			case 10 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:50: '\\ooooc'
            			    {
            			    	Match("ooooc"); 


            			    }
            			    break;
            			case 11 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:59: '%'
            			    {
            			    	Match('%'); 

            			    }
            			    break;
            			case 12 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:63: '\\r'
            			    {
            			    	Match('\r'); 

            			    }
            			    break;
            			case 13 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:68: '\\n'
            			    {
            			    	Match('\n'); 

            			    }
            			    break;
            			case 14 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:73: '_'
            			    {
            			    	Match('_'); 

            			    }
            			    break;
            			case 15 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:77: '/'
            			    {
            			    	Match('/'); 

            			    }
            			    break;
            			case 16 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:81: '\\\\'
            			    {
            			    	Match('\\'); 

            			    }
            			    break;
            			case 17 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:86: '>'
            			    {
            			    	Match('>'); 

            			    }
            			    break;
            			case 18 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:90: ','
            			    {
            			    	Match(','); 

            			    }
            			    break;
            			case 19 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:94: '!'
            			    {
            			    	Match('!'); 

            			    }
            			    break;
            			case 20 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:98: '$'
            			    {
            			    	Match('$'); 

            			    }
            			    break;
            			case 21 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:102: '('
            			    {
            			    	Match('('); 

            			    }
            			    break;
            			case 22 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:106: ')'
            			    {
            			    	Match(')'); 

            			    }
            			    break;
            			case 23 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:110: '='
            			    {
            			    	Match('='); 

            			    }
            			    break;
            			case 24 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:114: ']'
            			    {
            			    	Match(']'); 

            			    }
            			    break;
            			case 25 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:118: '['
            			    {
            			    	Match('['); 

            			    }
            			    break;
            			case 26 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:122: '.'
            			    {
            			    	Match('.'); 

            			    }
            			    break;
            			case 27 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:126: '<'
            			    {
            			    	Match('<'); 

            			    }
            			    break;
            			case 28 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:130: '-'
            			    {
            			    	Match('-'); 

            			    }
            			    break;
            			case 29 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:134: '&'
            			    {
            			    	Match('&'); 

            			    }
            			    break;
            			case 30 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:426:138: ' '
            			    {
            			    	Match(' '); 

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STR"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:427:3: ( CHAR ( CHAR | INT | '_' )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:427:5: CHAR ( CHAR | INT | '_' )*
            {
            	mCHAR(); 
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:427:9: ( CHAR | INT | '_' )*
            	do 
            	{
            	    int alt2 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 'A':
            	    case 'B':
            	    case 'C':
            	    case 'D':
            	    case 'E':
            	    case 'F':
            	    case 'G':
            	    case 'H':
            	    case 'I':
            	    case 'J':
            	    case 'K':
            	    case 'L':
            	    case 'M':
            	    case 'N':
            	    case 'O':
            	    case 'P':
            	    case 'Q':
            	    case 'R':
            	    case 'S':
            	    case 'T':
            	    case 'U':
            	    case 'V':
            	    case 'W':
            	    case 'X':
            	    case 'Y':
            	    case 'Z':
            	    case 'a':
            	    case 'b':
            	    case 'c':
            	    case 'd':
            	    case 'e':
            	    case 'f':
            	    case 'g':
            	    case 'h':
            	    case 'i':
            	    case 'j':
            	    case 'k':
            	    case 'l':
            	    case 'm':
            	    case 'n':
            	    case 'o':
            	    case 'p':
            	    case 'q':
            	    case 'r':
            	    case 's':
            	    case 't':
            	    case 'u':
            	    case 'v':
            	    case 'w':
            	    case 'x':
            	    case 'y':
            	    case 'z':
            	    	{
            	        alt2 = 1;
            	        }
            	        break;
            	    case '0':
            	    case '1':
            	    case '2':
            	    case '3':
            	    case '4':
            	    case '5':
            	    case '6':
            	    case '7':
            	    case '8':
            	    case '9':
            	    	{
            	        alt2 = 2;
            	        }
            	        break;
            	    case '_':
            	    	{
            	        alt2 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:427:10: CHAR
            			    {
            			    	mCHAR(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:427:15: INT
            			    {
            			    	mINT(); 

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:427:19: '_'
            			    {
            			    	Match('_'); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:428:14: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:428:16: ( 'a' .. 'z' | 'A' .. 'Z' )
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:429:4: ( ( DIGIT )+ )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:429:7: ( DIGIT )+
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:429:7: ( DIGIT )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:429:7: DIGIT
            			    {
            			    	mDIGIT(); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:11: ( ( '\\t' | ' ' | '\\r' | '\\n' | '\\ooooc' )+ )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:13: ( '\\t' | ' ' | '\\r' | '\\n' | '\\ooooc' )+
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:13: ( '\\t' | ' ' | '\\r' | '\\n' | '\\ooooc' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 6;
            	    switch ( input.LA(1) ) 
            	    {
            	    case '\t':
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case ' ':
            	    	{
            	        alt4 = 2;
            	        }
            	        break;
            	    case '\r':
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    case '\n':
            	    	{
            	        alt4 = 4;
            	        }
            	        break;
            	    case '\u0000':
            	    	{
            	        alt4 = 5;
            	        }
            	        break;

            	    }

            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:14: '\\t'
            			    {
            			    	Match('\t'); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:19: ' '
            			    {
            			    	Match(' '); 

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:23: '\\r'
            			    {
            			    	Match('\r'); 

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:28: '\\n'
            			    {
            			    	Match('\n'); 

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:430:33: '\\ooooc'
            			    {
            			    	Match("ooooc"); 


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "COMENTARIO"
    public void mCOMENTARIO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMENTARIO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:431:11: ( '/*' ( options {greedy=false; } : COMENTARIO | . )* '*/' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:431:13: '/*' ( options {greedy=false; } : COMENTARIO | . )* '*/'
            {
            	Match("/*"); 

            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:431:18: ( options {greedy=false; } : COMENTARIO | . )*
            	do 
            	{
            	    int alt5 = 3;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == '*') )
            	    {
            	        int LA5_1 = input.LA(2);

            	        if ( (LA5_1 == '/') )
            	        {
            	            alt5 = 3;
            	        }
            	        else if ( ((LA5_1 >= '\u0000' && LA5_1 <= '.') || (LA5_1 >= '0' && LA5_1 <= '\uFFFF')) )
            	        {
            	            alt5 = 2;
            	        }


            	    }
            	    else if ( (LA5_0 == '/') )
            	    {
            	        int LA5_2 = input.LA(2);

            	        if ( (LA5_2 == '*') )
            	        {
            	            alt5 = 1;
            	        }
            	        else if ( ((LA5_2 >= '\u0000' && LA5_2 <= ')') || (LA5_2 >= '+' && LA5_2 <= '\uFFFF')) )
            	        {
            	            alt5 = 2;
            	        }


            	    }
            	    else if ( ((LA5_0 >= '\u0000' && LA5_0 <= ')') || (LA5_0 >= '+' && LA5_0 <= '.') || (LA5_0 >= '0' && LA5_0 <= '\uFFFF')) )
            	    {
            	        alt5 = 2;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:431:45: COMENTARIO
            			    {
            			    	mCOMENTARIO(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:431:58: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	Match("*/"); 

            	_channel = HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMENTARIO"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:432:15: ( '0' .. '9' )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:432:17: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:8: ( MAS | MENOS | MULT | DIV | ASIG | IGUAL | MENOR | MAYOR | DIST | MENIG | MAYIG | PTO | DOSPTO | NIL | PTOCOM | PAR_A | PAR_C | COMA | COR_A | COR_C | LLAV_A | LLAV_C | OR | AND | OF | IF | THEN | ELSE | WHILE | DO | FOR | TO | BREAK | LET | IN | END | TYPE | VAR | ARRAY | FUNCTION | STR | ID | INT | WHITESPACE | COMENTARIO )
        int alt6 = 45;
        alt6 = dfa6.Predict(input);
        switch (alt6) 
        {
            case 1 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:10: MAS
                {
                	mMAS(); 

                }
                break;
            case 2 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:14: MENOS
                {
                	mMENOS(); 

                }
                break;
            case 3 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:20: MULT
                {
                	mMULT(); 

                }
                break;
            case 4 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:25: DIV
                {
                	mDIV(); 

                }
                break;
            case 5 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:29: ASIG
                {
                	mASIG(); 

                }
                break;
            case 6 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:34: IGUAL
                {
                	mIGUAL(); 

                }
                break;
            case 7 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:40: MENOR
                {
                	mMENOR(); 

                }
                break;
            case 8 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:46: MAYOR
                {
                	mMAYOR(); 

                }
                break;
            case 9 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:52: DIST
                {
                	mDIST(); 

                }
                break;
            case 10 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:57: MENIG
                {
                	mMENIG(); 

                }
                break;
            case 11 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:63: MAYIG
                {
                	mMAYIG(); 

                }
                break;
            case 12 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:69: PTO
                {
                	mPTO(); 

                }
                break;
            case 13 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:73: DOSPTO
                {
                	mDOSPTO(); 

                }
                break;
            case 14 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:80: NIL
                {
                	mNIL(); 

                }
                break;
            case 15 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:84: PTOCOM
                {
                	mPTOCOM(); 

                }
                break;
            case 16 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:91: PAR_A
                {
                	mPAR_A(); 

                }
                break;
            case 17 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:97: PAR_C
                {
                	mPAR_C(); 

                }
                break;
            case 18 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:103: COMA
                {
                	mCOMA(); 

                }
                break;
            case 19 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:108: COR_A
                {
                	mCOR_A(); 

                }
                break;
            case 20 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:114: COR_C
                {
                	mCOR_C(); 

                }
                break;
            case 21 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:120: LLAV_A
                {
                	mLLAV_A(); 

                }
                break;
            case 22 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:127: LLAV_C
                {
                	mLLAV_C(); 

                }
                break;
            case 23 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:134: OR
                {
                	mOR(); 

                }
                break;
            case 24 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:137: AND
                {
                	mAND(); 

                }
                break;
            case 25 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:141: OF
                {
                	mOF(); 

                }
                break;
            case 26 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:144: IF
                {
                	mIF(); 

                }
                break;
            case 27 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:147: THEN
                {
                	mTHEN(); 

                }
                break;
            case 28 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:152: ELSE
                {
                	mELSE(); 

                }
                break;
            case 29 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:157: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 30 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:163: DO
                {
                	mDO(); 

                }
                break;
            case 31 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:166: FOR
                {
                	mFOR(); 

                }
                break;
            case 32 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:170: TO
                {
                	mTO(); 

                }
                break;
            case 33 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:173: BREAK
                {
                	mBREAK(); 

                }
                break;
            case 34 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:179: LET
                {
                	mLET(); 

                }
                break;
            case 35 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:183: IN
                {
                	mIN(); 

                }
                break;
            case 36 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:186: END
                {
                	mEND(); 

                }
                break;
            case 37 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:190: TYPE
                {
                	mTYPE(); 

                }
                break;
            case 38 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:195: VAR
                {
                	mVAR(); 

                }
                break;
            case 39 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:199: ARRAY
                {
                	mARRAY(); 

                }
                break;
            case 40 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:205: FUNCTION
                {
                	mFUNCTION(); 

                }
                break;
            case 41 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:214: STR
                {
                	mSTR(); 

                }
                break;
            case 42 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:218: ID
                {
                	mID(); 

                }
                break;
            case 43 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:221: INT
                {
                	mINT(); 

                }
                break;
            case 44 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:225: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;
            case 45 :
                // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:1:236: COMENTARIO
                {
                	mCOMENTARIO(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	}

    const string DFA6_eotS =
        "\x04\uffff\x01\x25\x01\x27\x01\uffff\x01\x2a\x01\x2c\x01\uffff"+
        "\x01\x21\x0a\uffff\x0b\x21\x0d\uffff\x01\x21\x01\x3f\x01\x40\x01"+
        "\x41\x01\x21\x01\x43\x04\x21\x01\x48\x06\x21\x01\x4f\x03\uffff\x01"+
        "\x21\x01\uffff\x02\x21\x01\x53\x01\x21\x01\uffff\x01\x55\x02\x21"+
        "\x01\x58\x01\x59\x01\x21\x01\uffff\x01\x5b\x01\x5c\x01\x5d\x01\uffff"+
        "\x01\x21\x01\uffff\x02\x21\x02\uffff\x01\x21\x03\uffff\x01\x62\x01"+
        "\x21\x01\x64\x01\x65\x01\uffff\x01\x21\x02\uffff\x01\x21\x01\x68"+
        "\x01\uffff";
    const string DFA6_eofS =
        "\x69\uffff";
    const string DFA6_minS =
        "\x01\x00\x03\uffff\x01\x2a\x01\x3d\x01\uffff\x02\x3d\x01\uffff"+
        "\x01\x69\x0a\uffff\x02\x66\x01\x68\x01\x6c\x01\x68\x02\x6f\x01\x72"+
        "\x01\x65\x01\x61\x01\x72\x0d\uffff\x01\x6c\x03\x30\x01\x65\x01\x30"+
        "\x01\x70\x01\x73\x01\x64\x01\x69\x01\x30\x01\x72\x01\x6e\x01\x65"+
        "\x01\x74\x02\x72\x01\x30\x03\uffff\x01\x6e\x01\uffff\x02\x65\x01"+
        "\x30\x01\x6c\x01\uffff\x01\x30\x01\x63\x01\x61\x02\x30\x01\x61\x01"+
        "\uffff\x03\x30\x01\uffff\x01\x65\x01\uffff\x01\x74\x01\x6b\x02\uffff"+
        "\x01\x79\x03\uffff\x01\x30\x01\x69\x02\x30\x01\uffff\x01\x6f\x02"+
        "\uffff\x01\x6e\x01\x30\x01\uffff";
    const string DFA6_maxS =
        "\x01\x7d\x03\uffff\x01\x2a\x01\x3d\x01\uffff\x01\x3e\x01\x3d\x01"+
        "\uffff\x01\x69\x0a\uffff\x01\x66\x01\x6e\x01\x79\x01\x6e\x01\x68"+
        "\x01\x6f\x01\x75\x01\x72\x01\x65\x01\x61\x01\x72\x0d\uffff\x01\x6c"+
        "\x03\x7a\x01\x65\x01\x7a\x01\x70\x01\x73\x01\x64\x01\x69\x01\x7a"+
        "\x01\x72\x01\x6e\x01\x65\x01\x74\x02\x72\x01\x7a\x03\uffff\x01\x6e"+
        "\x01\uffff\x02\x65\x01\x7a\x01\x6c\x01\uffff\x01\x7a\x01\x63\x01"+
        "\x61\x02\x7a\x01\x61\x01\uffff\x03\x7a\x01\uffff\x01\x65\x01\uffff"+
        "\x01\x74\x01\x6b\x02\uffff\x01\x79\x03\uffff\x01\x7a\x01\x69\x02"+
        "\x7a\x01\uffff\x01\x6f\x02\uffff\x01\x6e\x01\x7a\x01\uffff";
    const string DFA6_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x06\x02\uffff"+
        "\x01\x0c\x01\uffff\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14"+
        "\x01\x15\x01\x16\x01\x17\x01\x18\x0b\uffff\x01\x29\x01\x2a\x01\x2b"+
        "\x01\x2c\x01\x2d\x01\x04\x01\x05\x01\x0d\x01\x09\x01\x0a\x01\x07"+
        "\x01\x0b\x01\x08\x12\uffff\x01\x19\x01\x1a\x01\x23\x01\uffff\x01"+
        "\x20\x04\uffff\x01\x1e\x06\uffff\x01\x0e\x03\uffff\x01\x24\x01\uffff"+
        "\x01\x1f\x02\uffff\x01\x22\x01\x26\x01\uffff\x01\x1b\x01\x25\x01"+
        "\x1c\x04\uffff\x01\x1d\x01\uffff\x01\x21\x01\x27\x02\uffff\x01\x28";
    const string DFA6_specialS =
        "\x69\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x23\x08\uffff\x02\x23\x02\uffff\x01\x23\x12\uffff\x01"+
            "\x23\x01\uffff\x01\x20\x03\uffff\x01\x14\x01\uffff\x01\x0c\x01"+
            "\x0d\x01\x03\x01\x01\x01\x0e\x01\x02\x01\x09\x01\x04\x0a\x22"+
            "\x01\x05\x01\x0b\x01\x07\x01\x06\x01\x08\x02\uffff\x1a\x21\x01"+
            "\x0f\x01\uffff\x01\x10\x03\uffff\x01\x1f\x01\x1c\x01\x21\x01"+
            "\x1a\x01\x18\x01\x1b\x02\x21\x01\x16\x02\x21\x01\x1d\x01\x21"+
            "\x01\x0a\x01\x15\x04\x21\x01\x17\x01\x21\x01\x1e\x01\x19\x03"+
            "\x21\x01\x11\x01\x13\x01\x12",
            "",
            "",
            "",
            "\x01\x24",
            "\x01\x26",
            "",
            "\x01\x29\x01\x28",
            "\x01\x2b",
            "",
            "\x01\x2d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2e",
            "\x01\x2f\x07\uffff\x01\x30",
            "\x01\x31\x06\uffff\x01\x32\x09\uffff\x01\x33",
            "\x01\x34\x01\uffff\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38\x05\uffff\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3e",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x42",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x44",
            "\x01\x45",
            "\x01\x46",
            "\x01\x47",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "",
            "",
            "\x01\x50",
            "",
            "\x01\x51",
            "\x01\x52",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x54",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x56",
            "\x01\x57",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x5a",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "\x01\x5e",
            "",
            "\x01\x5f",
            "\x01\x60",
            "",
            "",
            "\x01\x61",
            "",
            "",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x63",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "\x01\x66",
            "",
            "",
            "\x01\x67",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( MAS | MENOS | MULT | DIV | ASIG | IGUAL | MENOR | MAYOR | DIST | MENIG | MAYIG | PTO | DOSPTO | NIL | PTOCOM | PAR_A | PAR_C | COMA | COR_A | COR_C | LLAV_A | LLAV_C | OR | AND | OF | IF | THEN | ELSE | WHILE | DO | FOR | TO | BREAK | LET | IN | END | TYPE | VAR | ARRAY | FUNCTION | STR | ID | INT | WHITESPACE | COMENTARIO );"; }
        }

    }

 
    
}
