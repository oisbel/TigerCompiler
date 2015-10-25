// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g 2009-03-12 13:18:39


   using System;
   using System.Collections.Generic;
   using CompilersUtils;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

public class tiger_grammarParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"MAS", 
		"MENOS", 
		"MULT", 
		"DIV", 
		"ASIG", 
		"IGUAL", 
		"MENOR", 
		"MAYOR", 
		"DIST", 
		"MENIG", 
		"MAYIG", 
		"PTO", 
		"DOSPTO", 
		"NIL", 
		"PTOCOM", 
		"PAR_A", 
		"PAR_C", 
		"COMA", 
		"COR_A", 
		"COR_C", 
		"LLAV_A", 
		"LLAV_C", 
		"OR", 
		"AND", 
		"OF", 
		"IF", 
		"THEN", 
		"ELSE", 
		"WHILE", 
		"DO", 
		"FOR", 
		"TO", 
		"BREAK", 
		"LET", 
		"IN", 
		"END", 
		"TYPE", 
		"VAR", 
		"ARRAY", 
		"FUNCTION", 
		"STR", 
		"INT", 
		"ID", 
		"CHAR", 
		"DIGIT", 
		"WHITESPACE", 
		"COMENTARIO"
    };

    public const int FUNCTION = 43;
    public const int WHILE = 32;
    public const int COR_A = 22;
    public const int MENOS = 5;
    public const int MENOR = 10;
    public const int COR_C = 23;
    public const int CHAR = 47;
    public const int DO = 33;
    public const int FOR = 34;
    public const int ID = 46;
    public const int AND = 27;
    public const int EOF = -1;
    public const int BREAK = 36;
    public const int IF = 29;
    public const int TYPE = 40;
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



        public tiger_grammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public tiger_grammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        

    override public string[] TokenNames {
		get { return tiger_grammarParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g"; }
    }


       IList<string> errors = new List<string>();
       Dictionary<string, int> vars = new Dictionary<string, int>();

       public IList<string> Errors 
       { 
            get { return errors; }
       }

       public override void ReportError(RecognitionException e) 
       {
    	Errors.Add(e.ToString());
       }	
       
       public static void Main (string[]args)
       {
           tiger_grammarLexer lex = new tiger_grammarLexer(new ANTLRFileStream("codigos de prueba/8.txt"));
           CommonTokenStream tokens = new CommonTokenStream(lex);
           tiger_grammarParser parser= new tiger_grammarParser(tokens);
           try
           {
                parser.language();
                Console.WriteLine("press any key ...");
                Console.ReadLine();
           }
           catch(RecognitionException e)
           {
                Console.Error.WriteLine("mal sintaxis");
           }
       } 



    // $ANTLR start "language"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:91:1: language returns [TigerNode root] : ( expr_or | EOF );
    public TigerNode language() // throws RecognitionException [1]
    {   
        TigerNode root = null;

        TigerNode expr_or1 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:91:34: ( expr_or | EOF )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == MENOS || LA1_0 == NIL || LA1_0 == PAR_A || LA1_0 == IF || LA1_0 == WHILE || LA1_0 == FOR || (LA1_0 >= BREAK && LA1_0 <= LET) || (LA1_0 >= STR && LA1_0 <= ID)) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == EOF) )
            {
                alt1 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return root;}
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:91:36: expr_or
                    {
                    	PushFollow(FOLLOW_expr_or_in_language526);
                    	expr_or1 = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return root;
                    	if ( (state.backtracking==0) )
                    	{
                    	  root =  expr_or1;
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:91:66: EOF
                    {
                    	Match(input,EOF,FOLLOW_EOF_in_language529); if (state.failed) return root;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return root;
    }
    // $ANTLR end "language"


    // $ANTLR start "expr_or"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:93:1: expr_or returns [TigerNode or] : exp1= expr_and ( OR exp2= expr_and )* ;
    public TigerNode expr_or() // throws RecognitionException [1]
    {   
        TigerNode or = null;

        IToken OR2 = null;
        TigerNode exp1 = null;

        TigerNode exp2 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:93:31: (exp1= expr_and ( OR exp2= expr_and )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:93:33: exp1= expr_and ( OR exp2= expr_and )*
            {
            	PushFollow(FOLLOW_expr_and_in_expr_or542);
            	exp1 = expr_and();
            	state.followingStackPointer--;
            	if (state.failed) return or;
            	if ( (state.backtracking==0) )
            	{
            	  or =  exp1;
            	}
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:94:25: ( OR exp2= expr_and )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == OR) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:94:26: OR exp2= expr_and
            			    {
            			    	OR2=(IToken)Match(input,OR,FOLLOW_OR_in_expr_or571); if (state.failed) return or;
            			    	PushFollow(FOLLOW_expr_and_in_expr_or576);
            			    	exp2 = expr_and();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return or;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                               or =  new OrNode(or, exp2);
            			    	                                               or.Col= OR2.CharPositionInLine; 
            			    	                                               or.Row = OR2.Line;
            			    	                                              
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return or;
    }
    // $ANTLR end "expr_or"


    // $ANTLR start "expr_and"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:100:1: expr_and returns [TigerNode and] : exp1= expr_comp ( AND exp2= expr_comp )* ;
    public TigerNode expr_and() // throws RecognitionException [1]
    {   
        TigerNode and = null;

        IToken AND3 = null;
        TigerNode exp1 = null;

        TigerNode exp2 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:100:35: (exp1= expr_comp ( AND exp2= expr_comp )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:100:37: exp1= expr_comp ( AND exp2= expr_comp )*
            {
            	PushFollow(FOLLOW_expr_comp_in_expr_and631);
            	exp1 = expr_comp();
            	state.followingStackPointer--;
            	if (state.failed) return and;
            	if ( (state.backtracking==0) )
            	{
            	  and =  exp1;
            	}
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:101:26: ( AND exp2= expr_comp )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == AND) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:101:27: AND exp2= expr_comp
            			    {
            			    	AND3=(IToken)Match(input,AND,FOLLOW_AND_in_expr_and661); if (state.failed) return and;
            			    	PushFollow(FOLLOW_expr_comp_in_expr_and665);
            			    	exp2 = expr_comp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return and;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                and =  new AndNode(and, exp2);
            			    	                                                and.Col=AND3.CharPositionInLine; 
            			    	                                                and.Row = AND3.Line;
            			    	                                              
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return and;
    }
    // $ANTLR end "expr_and"


    // $ANTLR start "expr_comp"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:108:1: expr_comp returns [TigerNode comp] : exp1= expr_pm ( IGUAL i= expr_pm | MAYOR o= expr_pm | MENOR p= expr_pm | DIST e= expr_pm | MENIG r= expr_pm | MAYIG f= expr_pm )* ;
    public TigerNode expr_comp() // throws RecognitionException [1]
    {   
        TigerNode comp = null;

        IToken IGUAL4 = null;
        IToken MAYOR5 = null;
        IToken MENOR6 = null;
        IToken DIST7 = null;
        IToken MENIG8 = null;
        IToken MAYIG9 = null;
        TigerNode exp1 = null;

        TigerNode i = null;

        TigerNode o = null;

        TigerNode p = null;

        TigerNode e = null;

        TigerNode r = null;

        TigerNode f = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:108:36: (exp1= expr_pm ( IGUAL i= expr_pm | MAYOR o= expr_pm | MENOR p= expr_pm | DIST e= expr_pm | MENIG r= expr_pm | MAYIG f= expr_pm )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:108:38: exp1= expr_pm ( IGUAL i= expr_pm | MAYOR o= expr_pm | MENOR p= expr_pm | DIST e= expr_pm | MENIG r= expr_pm | MAYIG f= expr_pm )*
            {
            	PushFollow(FOLLOW_expr_pm_in_expr_comp684);
            	exp1 = expr_pm();
            	state.followingStackPointer--;
            	if (state.failed) return comp;
            	if ( (state.backtracking==0) )
            	{
            	  comp = exp1;
            	}
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:109:28: ( IGUAL i= expr_pm | MAYOR o= expr_pm | MENOR p= expr_pm | DIST e= expr_pm | MENIG r= expr_pm | MAYIG f= expr_pm )*
            	do 
            	{
            	    int alt4 = 7;
            	    switch ( input.LA(1) ) 
            	    {
            	    case IGUAL:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case MAYOR:
            	    	{
            	        alt4 = 2;
            	        }
            	        break;
            	    case MENOR:
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    case DIST:
            	    	{
            	        alt4 = 4;
            	        }
            	        break;
            	    case MENIG:
            	    	{
            	        alt4 = 5;
            	        }
            	        break;
            	    case MAYIG:
            	    	{
            	        alt4 = 6;
            	        }
            	        break;

            	    }

            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:109:29: IGUAL i= expr_pm
            			    {
            			    	IGUAL4=(IToken)Match(input,IGUAL,FOLLOW_IGUAL_in_expr_comp742); if (state.failed) return comp;
            			    	PushFollow(FOLLOW_expr_pm_in_expr_comp746);
            			    	i = expr_pm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return comp;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                comp =  new EqualNode(comp, i); 
            			    	                                                comp.Col=IGUAL4.CharPositionInLine; 
            			    	                                                comp.Row = IGUAL4.Line;
            			    	                                		    
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:114:19: MAYOR o= expr_pm
            			    {
            			    	MAYOR5=(IToken)Match(input,MAYOR,FOLLOW_MAYOR_in_expr_comp768); if (state.failed) return comp;
            			    	PushFollow(FOLLOW_expr_pm_in_expr_comp772);
            			    	o = expr_pm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return comp;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                comp =  new GreaterThanNode(comp, o); 
            			    	                                                comp.Col=MAYOR5.CharPositionInLine; 
            			    	                                                comp.Row = MAYOR5.Line;
            			    	                                             
            			    	}

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:119:28: MENOR p= expr_pm
            			    {
            			    	MENOR6=(IToken)Match(input,MENOR,FOLLOW_MENOR_in_expr_comp805); if (state.failed) return comp;
            			    	PushFollow(FOLLOW_expr_pm_in_expr_comp809);
            			    	p = expr_pm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return comp;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                comp =  new LessThanNode(comp,p); 
            			    	                                                comp.Col=MENOR6.CharPositionInLine; 
            			    	                                                comp.Row = MENOR6.Line;
            			    	                                             
            			    	}

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:124:28: DIST e= expr_pm
            			    {
            			    	DIST7=(IToken)Match(input,DIST,FOLLOW_DIST_in_expr_comp841); if (state.failed) return comp;
            			    	PushFollow(FOLLOW_expr_pm_in_expr_comp845);
            			    	e = expr_pm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return comp;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                comp =  new DistinctNode(comp, e); 
            			    	                                                comp.Col=DIST7.CharPositionInLine; 
            			    	                                                comp.Row = DIST7.Line;
            			    	                                             
            			    	}

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:129:28: MENIG r= expr_pm
            			    {
            			    	MENIG8=(IToken)Match(input,MENIG,FOLLOW_MENIG_in_expr_comp879); if (state.failed) return comp;
            			    	PushFollow(FOLLOW_expr_pm_in_expr_comp883);
            			    	r = expr_pm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return comp;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                comp =  new LessEqualThanNode(comp,r); 
            			    	                                                comp.Col=MENIG8.CharPositionInLine; 
            			    	                                                comp.Row = MENIG8.Line;
            			    	                                             
            			    	}

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:134:28: MAYIG f= expr_pm
            			    {
            			    	MAYIG9=(IToken)Match(input,MAYIG,FOLLOW_MAYIG_in_expr_comp916); if (state.failed) return comp;
            			    	PushFollow(FOLLOW_expr_pm_in_expr_comp920);
            			    	f = expr_pm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return comp;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                comp =  new GreaterEqualThanNode(comp,f); 
            			    	                                                comp.Col=MAYIG9.CharPositionInLine; 
            			    	                                                comp.Row = MAYIG9.Line;
            			    	                                             
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return comp;
    }
    // $ANTLR end "expr_comp"


    // $ANTLR start "expr_pm"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:141:1: expr_pm returns [TigerNode pm] : exp1= expr_dm ( MAS a= expr_dm | MENOS b= expr_dm )* ;
    public TigerNode expr_pm() // throws RecognitionException [1]
    {   
        TigerNode pm = null;

        IToken MAS10 = null;
        IToken MENOS11 = null;
        TigerNode exp1 = null;

        TigerNode a = null;

        TigerNode b = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:141:31: (exp1= expr_dm ( MAS a= expr_dm | MENOS b= expr_dm )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:141:33: exp1= expr_dm ( MAS a= expr_dm | MENOS b= expr_dm )*
            {
            	PushFollow(FOLLOW_expr_dm_in_expr_pm938);
            	exp1 = expr_dm();
            	state.followingStackPointer--;
            	if (state.failed) return pm;
            	if ( (state.backtracking==0) )
            	{
            	   pm =  exp1; 
            	}
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:142:28: ( MAS a= expr_dm | MENOS b= expr_dm )*
            	do 
            	{
            	    int alt5 = 3;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == MAS) )
            	    {
            	        alt5 = 1;
            	    }
            	    else if ( (LA5_0 == MENOS) )
            	    {
            	        alt5 = 2;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:142:30: MAS a= expr_dm
            			    {
            			    	MAS10=(IToken)Match(input,MAS,FOLLOW_MAS_in_expr_pm971); if (state.failed) return pm;
            			    	PushFollow(FOLLOW_expr_dm_in_expr_pm975);
            			    	a = expr_dm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return pm;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                 pm =  new PlusNode(pm, a); 
            			    	                                                 pm.Col=MAS10.CharPositionInLine; 
            			    	                                                 pm.Row = MAS10.Line;
            			    	                                              
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:147:30: MENOS b= expr_dm
            			    {
            			    	MENOS11=(IToken)Match(input,MENOS,FOLLOW_MENOS_in_expr_pm1009); if (state.failed) return pm;
            			    	PushFollow(FOLLOW_expr_dm_in_expr_pm1013);
            			    	b = expr_dm();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return pm;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                  pm =  new MinusNode(pm, b); 
            			    	                                                  pm.Col=MENOS11.CharPositionInLine; 
            			    	                                                  pm.Row = MENOS11.Line;
            			    	                                              
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return pm;
    }
    // $ANTLR end "expr_pm"


    // $ANTLR start "expr_dm"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:154:1: expr_dm returns [TigerNode dm] : exp1= expr ( MULT a= expr | DIV b= expr )* ;
    public TigerNode expr_dm() // throws RecognitionException [1]
    {   
        TigerNode dm = null;

        IToken MULT12 = null;
        IToken DIV13 = null;
        TigerNode exp1 = null;

        TigerNode a = null;

        TigerNode b = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:154:32: (exp1= expr ( MULT a= expr | DIV b= expr )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:154:34: exp1= expr ( MULT a= expr | DIV b= expr )*
            {
            	PushFollow(FOLLOW_expr_in_expr_dm1033);
            	exp1 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return dm;
            	if ( (state.backtracking==0) )
            	{
            	  dm =  exp1; 
            	}
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:155:36: ( MULT a= expr | DIV b= expr )*
            	do 
            	{
            	    int alt6 = 3;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == MULT) )
            	    {
            	        alt6 = 1;
            	    }
            	    else if ( (LA6_0 == DIV) )
            	    {
            	        alt6 = 2;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:155:37: MULT a= expr
            			    {
            			    	MULT12=(IToken)Match(input,MULT,FOLLOW_MULT_in_expr_dm1073); if (state.failed) return dm;
            			    	PushFollow(FOLLOW_expr_in_expr_dm1077);
            			    	a = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return dm;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                        dm =  new MultNode(dm, a); 
            			    	                                                        dm.Col=MULT12.CharPositionInLine; 
            			    	                                                        dm.Row = MULT12.Line;
            			    	                                                    
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:160:37: DIV b= expr
            			    {
            			    	DIV13=(IToken)Match(input,DIV,FOLLOW_DIV_in_expr_dm1118); if (state.failed) return dm;
            			    	PushFollow(FOLLOW_expr_in_expr_dm1122);
            			    	b = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return dm;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                        dm =  new DivNode(dm, b);
            			    	                                                        dm.Col=DIV13.CharPositionInLine; 
            			    	                                                        dm.Row = DIV13.Line;
            			    	                                                   
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return dm;
    }
    // $ANTLR end "expr_dm"


    // $ANTLR start "expr"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:167:1: expr returns [TigerNode exp] : ( STR | INT | id1= ID ( ( COR_A expr_or COR_C OF )=> COR_A idexp1= expr_or COR_C OF idexp= expr_or | idp4= ptocor ida1= asig | LLAV_A fieldlist LLAV_C idp1= ptocor | PAR_A exprlist PAR_C idp3= ptocor ) | MENOS expr_or | BREAK | NIL | PAR_A exprseq PAR_C idp9= ptocor | IF idif= expr_or THEN idthen= expr_or ifthenelse | WHILE idexp3= expr_or DO iddo= expr_or | FOR id5= ID ASIG idasig= expr_or TO idto= expr_or DO iddo= expr_or | LET decllist IN exprseq END );
    public TigerNode expr() // throws RecognitionException [1]
    {   
        TigerNode exp = null;

        IToken id1 = null;
        IToken id5 = null;
        IToken STR14 = null;
        IToken INT15 = null;
        IToken MENOS19 = null;
        IToken BREAK20 = null;
        IToken NIL21 = null;
        IToken PAR_A23 = null;
        IToken IF25 = null;
        IToken WHILE26 = null;
        IToken FOR27 = null;
        IToken LET30 = null;
        TigerNode idexp1 = null;

        TigerNode idexp = null;

        List<Access> idp4 = null;

        AssingmentNode ida1 = null;

        List<Access> idp1 = null;

        List<Access> idp3 = null;

        List<Access> idp9 = null;

        TigerNode idif = null;

        TigerNode idthen = null;

        TigerNode idexp3 = null;

        TigerNode iddo = null;

        TigerNode idasig = null;

        TigerNode idto = null;

        tiger_grammarParser.fieldlist_return fieldlist16 = null;

        List<TigerNode> exprlist17 = null;

        TigerNode expr_or18 = null;

        List<TigerNode> exprseq22 = null;

        TigerNode ifthenelse24 = null;

        List<DeclarationNode> decllist28 = null;

        List<TigerNode> exprseq29 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:167:30: ( STR | INT | id1= ID ( ( COR_A expr_or COR_C OF )=> COR_A idexp1= expr_or COR_C OF idexp= expr_or | idp4= ptocor ida1= asig | LLAV_A fieldlist LLAV_C idp1= ptocor | PAR_A exprlist PAR_C idp3= ptocor ) | MENOS expr_or | BREAK | NIL | PAR_A exprseq PAR_C idp9= ptocor | IF idif= expr_or THEN idthen= expr_or ifthenelse | WHILE idexp3= expr_or DO iddo= expr_or | FOR id5= ID ASIG idasig= expr_or TO idto= expr_or DO iddo= expr_or | LET decllist IN exprseq END )
            int alt8 = 11;
            switch ( input.LA(1) ) 
            {
            case STR:
            	{
                alt8 = 1;
                }
                break;
            case INT:
            	{
                alt8 = 2;
                }
                break;
            case ID:
            	{
                alt8 = 3;
                }
                break;
            case MENOS:
            	{
                alt8 = 4;
                }
                break;
            case BREAK:
            	{
                alt8 = 5;
                }
                break;
            case NIL:
            	{
                alt8 = 6;
                }
                break;
            case PAR_A:
            	{
                alt8 = 7;
                }
                break;
            case IF:
            	{
                alt8 = 8;
                }
                break;
            case WHILE:
            	{
                alt8 = 9;
                }
                break;
            case FOR:
            	{
                alt8 = 10;
                }
                break;
            case LET:
            	{
                alt8 = 11;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return exp;}
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:168:13: STR
                    {
                    	STR14=(IToken)Match(input,STR,FOLLOW_STR_in_expr1153); if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	                       string s = STR14.Text;
                    	                       string[] t = s.Split('"');
                    	              	     exp =  new StringNode(t[1]); 
                    	              	     exp.Col=STR14.CharPositionInLine; 
                    	              	     exp.Row=STR14.Line;
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:175:13: INT
                    {
                    	INT15=(IToken)Match(input,INT,FOLLOW_INT_in_expr1172); if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	                       exp =  new IntNode(int.Parse(INT15.Text)); 
                    	                       exp.Col=INT15.CharPositionInLine; 
                    	                       exp.Row=INT15.Line;
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:180:13: id1= ID ( ( COR_A expr_or COR_C OF )=> COR_A idexp1= expr_or COR_C OF idexp= expr_or | idp4= ptocor ida1= asig | LLAV_A fieldlist LLAV_C idp1= ptocor | PAR_A exprlist PAR_C idp3= ptocor )
                    {
                    	id1=(IToken)Match(input,ID,FOLLOW_ID_in_expr1204); if (state.failed) return exp;
                    	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:180:20: ( ( COR_A expr_or COR_C OF )=> COR_A idexp1= expr_or COR_C OF idexp= expr_or | idp4= ptocor ida1= asig | LLAV_A fieldlist LLAV_C idp1= ptocor | PAR_A exprlist PAR_C idp3= ptocor )
                    	int alt7 = 4;
                    	alt7 = dfa7.Predict(input);
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:181:24: ( COR_A expr_or COR_C OF )=> COR_A idexp1= expr_or COR_C OF idexp= expr_or
                    	        {
                    	        	Match(input,COR_A,FOLLOW_COR_A_in_expr1245); if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_expr_or_in_expr1249);
                    	        	idexp1 = expr_or();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	Match(input,COR_C,FOLLOW_COR_C_in_expr1251); if (state.failed) return exp;
                    	        	Match(input,OF,FOLLOW_OF_in_expr1253); if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_expr_or_in_expr1257);
                    	        	idexp = expr_or();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	                                     exp =  new ArrayNode(id1.Text,idexp1,idexp);
                    	        	                                     exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	                                 
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:186:24: idp4= ptocor ida1= asig
                    	        {
                    	        	PushFollow(FOLLOW_ptocor_in_expr1318);
                    	        	idp4 = ptocor();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_asig_in_expr1322);
                    	        	ida1 = asig();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	              		       if(idp4.Count > 0 && ida1 !=null)
                    	        	              		       {
                    	        	              		           exp =  ida1;
                    	        	              		           ((AssingmentNode)exp).LeftExpr = new ListLValueNode(new VariableNode(id1.Text),idp4);
                    	        	              		           exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	              		       }
                    	        	              		       else if(idp4.Count > 0)
                    	        	              		       {
                    	        	              		           exp =  new ListLValueNode(new VariableNode(id1.Text),idp4);
                    	        	              		           exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	              		       }
                    	        	              		       else if(ida1 !=null)
                    	        	              		       {
                    	        	              		           exp =  ida1;
                    	        	              		           ((AssingmentNode)exp).LeftExpr = new VariableNode(id1.Text);
                    	        	              		           exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	              		       }
                    	        	              		       else
                    	        	              		       {
                    	        	              		           exp =  new VariableNode(id1.Text);
                    	        	              		           exp.Col=id1.CharPositionInLine; 
                    	        	              		           exp.Row=id1.Line;
                    	        	              		       }            		     
                    	        	                        
                    	        	}

                    	        }
                    	        break;
                    	    case 3 :
                    	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:211:23: LLAV_A fieldlist LLAV_C idp1= ptocor
                    	        {
                    	        	Match(input,LLAV_A,FOLLOW_LLAV_A_in_expr1349); if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_fieldlist_in_expr1351);
                    	        	fieldlist16 = fieldlist();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	Match(input,LLAV_C,FOLLOW_LLAV_C_in_expr1353); if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_ptocor_in_expr1357);
                    	        	idp1 = ptocor();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	                               if(idp1.Count > 0)
                    	        	                               {
                    	        	                                   exp =  new ListLValueNode(new RecordNode(id1.Text, ((fieldlist16 != null) ? fieldlist16.listid : null), ((fieldlist16 != null) ? fieldlist16.listexp : null)),idp1);
                    	        	                                   exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	                               }
                    	        	                                    else{ exp =  new RecordNode(id1.Text, ((fieldlist16 != null) ? fieldlist16.listid : null), ((fieldlist16 != null) ? fieldlist16.listexp : null));
                    	        	                                          exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	                                        }
                    	        	                             
                    	        	}

                    	        }
                    	        break;
                    	    case 4 :
                    	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:221:22: PAR_A exprlist PAR_C idp3= ptocor
                    	        {
                    	        	Match(input,PAR_A,FOLLOW_PAR_A_in_expr1382); if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_exprlist_in_expr1384);
                    	        	exprlist17 = exprlist();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	Match(input,PAR_C,FOLLOW_PAR_C_in_expr1386); if (state.failed) return exp;
                    	        	PushFollow(FOLLOW_ptocor_in_expr1390);
                    	        	idp3 = ptocor();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return exp;
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   
                    	        	                              if(idp3.Count > 0)
                    	        	                              {
                    	        	                                  exp =  new ListLValueNode(new CallFunctionNode(id1.Text, exprlist17),idp3);
                    	        	                                  exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	                              }
                    	        	                              else{ exp =  new CallFunctionNode(id1.Text, exprlist17);
                    	        	                                    exp.Col=id1.CharPositionInLine; exp.Row=id1.Line;
                    	        	                              }
                    	        	              
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:233:13: MENOS expr_or
                    {
                    	MENOS19=(IToken)Match(input,MENOS,FOLLOW_MENOS_in_expr1446); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1448);
                    	expr_or18 = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{

                    	                             exp =  new MinusUnaryNode(expr_or18); 
                    	                             exp.Col=MENOS19.CharPositionInLine; 
                    	                             exp.Row = MENOS19.Line;
                    	                         
                    	}

                    }
                    break;
                case 5 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:239:13: BREAK
                    {
                    	BREAK20=(IToken)Match(input,BREAK,FOLLOW_BREAK_in_expr1478); if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{

                    	                         exp =  new BreakNode(); 
                    	                         exp.Col=BREAK20.CharPositionInLine;
                    	                         exp.Row = BREAK20.Line;
                    	                    
                    	}

                    }
                    break;
                case 6 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:245:13: NIL
                    {
                    	NIL21=(IToken)Match(input,NIL,FOLLOW_NIL_in_expr1508); if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{

                    	                         exp =  new NilNode(); 
                    	                         exp.Col=NIL21.CharPositionInLine;
                    	                         exp.Row = NIL21.Line;
                    	                  
                    	}

                    }
                    break;
                case 7 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:251:13: PAR_A exprseq PAR_C idp9= ptocor
                    {
                    	PAR_A23=(IToken)Match(input,PAR_A,FOLLOW_PAR_A_in_expr1538); if (state.failed) return exp;
                    	PushFollow(FOLLOW_exprseq_in_expr1540);
                    	exprseq22 = exprseq();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,PAR_C,FOLLOW_PAR_C_in_expr1542); if (state.failed) return exp;
                    	PushFollow(FOLLOW_ptocor_in_expr1546);
                    	idp9 = ptocor();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	              			if(idp9.Count > 0)
                    	                                  {
                    	                                     exp =  new ListLValueNode(new ExprSeqNode(exprseq22),idp9);
                    	                                     exp.Col=PAR_A23.CharPositionInLine;
                    	                                     exp.Row = PAR_A23.Line;
                    	                                  }
                    	                                  else{
                    	                                     exp =  new ExprSeqNode(exprseq22);
                    	                                     exp.Col=PAR_A23.CharPositionInLine;
                    	                                     exp.Row = PAR_A23.Line;
                    	                                     }
                    	                                  
                    	}

                    }
                    break;
                case 8 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:265:13: IF idif= expr_or THEN idthen= expr_or ifthenelse
                    {
                    	IF25=(IToken)Match(input,IF,FOLLOW_IF_in_expr1577); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1581);
                    	idif = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,THEN,FOLLOW_THEN_in_expr1583); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1587);
                    	idthen = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	PushFollow(FOLLOW_ifthenelse_in_expr1589);
                    	ifthenelse24 = ifthenelse();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{

                    	              		if(ifthenelse24!=null)
                    	              		{
                    	              			exp =  new IfThenElseNode(idif, idthen, ifthenelse24);
                    	              		} 
                    	              		else{ 
                    	              		        exp =  new IfThenNode(idif, idthen);
                    	              		    }
                    	              
                    	              		exp.Col = IF25.CharPositionInLine; 
                    	              		exp.Row = IF25.Line;
                    	             	    
                    	}

                    }
                    break;
                case 9 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:278:13: WHILE idexp3= expr_or DO iddo= expr_or
                    {
                    	WHILE26=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1627); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1631);
                    	idexp3 = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,DO,FOLLOW_DO_in_expr1633); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1637);
                    	iddo = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{
                    	   exp =  new WhileNode(idexp3,iddo);
                    	                                              exp.Col = WHILE26.CharPositionInLine; 
                    	              				    exp.Row = WHILE26.Line;
                    	                                           
                    	}

                    }
                    break;
                case 10 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:283:13: FOR id5= ID ASIG idasig= expr_or TO idto= expr_or DO iddo= expr_or
                    {
                    	FOR27=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1665); if (state.failed) return exp;
                    	id5=(IToken)Match(input,ID,FOLLOW_ID_in_expr1669); if (state.failed) return exp;
                    	Match(input,ASIG,FOLLOW_ASIG_in_expr1671); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1675);
                    	idasig = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,TO,FOLLOW_TO_in_expr1677); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1681);
                    	idto = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,DO,FOLLOW_DO_in_expr1683); if (state.failed) return exp;
                    	PushFollow(FOLLOW_expr_or_in_expr1687);
                    	iddo = expr_or();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{

                    	                                              exp =  new ForNode(id5.Text,idasig,idto,iddo);
                    	                                              exp.Col = FOR27.CharPositionInLine; 
                    	              				    exp.Row = FOR27.Line;
                    	                                            
                    	}

                    }
                    break;
                case 11 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:289:13: LET decllist IN exprseq END
                    {
                    	LET30=(IToken)Match(input,LET,FOLLOW_LET_in_expr1716); if (state.failed) return exp;
                    	PushFollow(FOLLOW_decllist_in_expr1718);
                    	decllist28 = decllist();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,IN,FOLLOW_IN_in_expr1720); if (state.failed) return exp;
                    	PushFollow(FOLLOW_exprseq_in_expr1722);
                    	exprseq29 = exprseq();
                    	state.followingStackPointer--;
                    	if (state.failed) return exp;
                    	Match(input,END,FOLLOW_END_in_expr1725); if (state.failed) return exp;
                    	if ( (state.backtracking==0) )
                    	{
                    	    
                    	                                             exp =  new LetNode(decllist28,exprseq29);
                    	              				   exp.Col= LET30.CharPositionInLine; 
                    	              				   exp.Row = LET30.Line;
                    	              				
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return exp;
    }
    // $ANTLR end "expr"


    // $ANTLR start "ptocor"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:296:1: ptocor returns [List<Access> list] : ( PTO id3= ID | COR_A expr_or COR_C )* ;
    public List<Access> ptocor() // throws RecognitionException [1]
    {   
        List<Access> list = null;

        IToken id3 = null;
        TigerNode expr_or31 = null;


        list =  new List<Access>();
        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:296:70: ( ( PTO id3= ID | COR_A expr_or COR_C )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:297:40: ( PTO id3= ID | COR_A expr_or COR_C )*
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:297:40: ( PTO id3= ID | COR_A expr_or COR_C )*
            	do 
            	{
            	    int alt9 = 3;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == PTO) )
            	    {
            	        alt9 = 1;
            	    }
            	    else if ( (LA9_0 == COR_A) )
            	    {
            	        alt9 = 2;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:297:41: PTO id3= ID
            			    {
            			    	Match(input,PTO,FOLLOW_PTO_in_ptocor1785); if (state.failed) return list;
            			    	id3=(IToken)Match(input,ID,FOLLOW_ID_in_ptocor1789); if (state.failed) return list;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                         list.Add(new AccessRecord(id3.Text));
            			    	                                                     
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:300:35: COR_A expr_or COR_C
            			    {
            			    	Match(input,COR_A,FOLLOW_COR_A_in_ptocor1828); if (state.failed) return list;
            			    	PushFollow(FOLLOW_expr_or_in_ptocor1830);
            			    	expr_or31 = expr_or();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return list;
            			    	Match(input,COR_C,FOLLOW_COR_C_in_ptocor1832); if (state.failed) return list;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                         list.Add(new AccessArray(expr_or31));
            			    	                                                     
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return list;
    }
    // $ANTLR end "ptocor"


    // $ANTLR start "asig"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:305:1: asig returns [AssingmentNode a] : ( ASIG expr_or )? ;
    public AssingmentNode asig() // throws RecognitionException [1]
    {   
        AssingmentNode a = null;

        TigerNode expr_or32 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:305:31: ( ( ASIG expr_or )? )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:305:33: ( ASIG expr_or )?
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:305:33: ( ASIG expr_or )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == ASIG) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:305:34: ASIG expr_or
            	        {
            	        	Match(input,ASIG,FOLLOW_ASIG_in_asig1848); if (state.failed) return a;
            	        	PushFollow(FOLLOW_expr_or_in_asig1850);
            	        	expr_or32 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return a;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	                                               a =  new AssingmentNode(null,expr_or32);
            	        	                                            
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return a;
    }
    // $ANTLR end "asig"


    // $ANTLR start "ifthenelse"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:310:1: ifthenelse returns [TigerNode els] : ( ELSE expr_or )? ;
    public TigerNode ifthenelse() // throws RecognitionException [1]
    {   
        TigerNode els = null;

        IToken ELSE34 = null;
        TigerNode expr_or33 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:310:34: ( ( ELSE expr_or )? )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:310:36: ( ELSE expr_or )?
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:310:36: ( ELSE expr_or )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == ELSE) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:310:37: ELSE expr_or
            	        {
            	        	ELSE34=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_ifthenelse1865); if (state.failed) return els;
            	        	PushFollow(FOLLOW_expr_or_in_ifthenelse1867);
            	        	expr_or33 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return els;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	    
            	        	                                                   els =  expr_or33;
            	        	                                                   els.Col=ELSE34.CharPositionInLine; 
            	        	              				         els.Row = ELSE34.Line;
            	        	              				     
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return els;
    }
    // $ANTLR end "ifthenelse"


    // $ANTLR start "exprlist"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:317:1: exprlist returns [List<TigerNode> list] : (idexp1= expr_or ( COMA idexp2= expr_or )* )? ;
    public List<TigerNode> exprlist() // throws RecognitionException [1]
    {   
        List<TigerNode> list = null;

        TigerNode idexp1 = null;

        TigerNode idexp2 = null;


        list =  new List<TigerNode>();
        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:317:78: ( (idexp1= expr_or ( COMA idexp2= expr_or )* )? )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:318:45: (idexp1= expr_or ( COMA idexp2= expr_or )* )?
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:318:45: (idexp1= expr_or ( COMA idexp2= expr_or )* )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == MENOS || LA13_0 == NIL || LA13_0 == PAR_A || LA13_0 == IF || LA13_0 == WHILE || LA13_0 == FOR || (LA13_0 >= BREAK && LA13_0 <= LET) || (LA13_0 >= STR && LA13_0 <= ID)) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:318:46: idexp1= expr_or ( COMA idexp2= expr_or )*
            	        {
            	        	PushFollow(FOLLOW_expr_or_in_exprlist1935);
            	        	idexp1 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return list;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	                                                               list.Add(idexp1);
            	        	                                                           
            	        	}
            	        	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:321:40: ( COMA idexp2= expr_or )*
            	        	do 
            	        	{
            	        	    int alt12 = 2;
            	        	    int LA12_0 = input.LA(1);

            	        	    if ( (LA12_0 == COMA) )
            	        	    {
            	        	        alt12 = 1;
            	        	    }


            	        	    switch (alt12) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:321:41: COMA idexp2= expr_or
            	        			    {
            	        			    	Match(input,COMA,FOLLOW_COMA_in_exprlist1979); if (state.failed) return list;
            	        			    	PushFollow(FOLLOW_expr_or_in_exprlist1983);
            	        			    	idexp2 = expr_or();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return list;
            	        			    	if ( (state.backtracking==0) )
            	        			    	{
            	        			    	   
            	        			    	                                                                list.Add(idexp2);
            	        			    	                                              		      
            	        			    	                                                           
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop12;
            	        	    }
            	        	} while (true);

            	        	loop12:
            	        		;	// Stops C# compiler whining that label 'loop12' has no statements


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return list;
    }
    // $ANTLR end "exprlist"

    public class fieldlist_return : ParserRuleReturnScope
    {
        public List<string> listid;
        public List<TigerNode> listexp;
    };

    // $ANTLR start "fieldlist"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:327:1: fieldlist returns [List<string> listid,List<TigerNode> listexp] : id1= ID IGUAL idexp= expr_or ( COMA id2= ID IGUAL idexp2= expr_or )* ;
    public tiger_grammarParser.fieldlist_return fieldlist() // throws RecognitionException [1]
    {   
        tiger_grammarParser.fieldlist_return retval = new tiger_grammarParser.fieldlist_return();
        retval.Start = input.LT(1);

        IToken id1 = null;
        IToken id2 = null;
        TigerNode idexp = null;

        TigerNode idexp2 = null;


        retval.listid =  new List<string>(); retval.listexp =  new List<TigerNode>();
        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:327:134: (id1= ID IGUAL idexp= expr_or ( COMA id2= ID IGUAL idexp2= expr_or )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:328:35: id1= ID IGUAL idexp= expr_or ( COMA id2= ID IGUAL idexp2= expr_or )*
            {
            	id1=(IToken)Match(input,ID,FOLLOW_ID_in_fieldlist2041); if (state.failed) return retval;
            	Match(input,IGUAL,FOLLOW_IGUAL_in_fieldlist2043); if (state.failed) return retval;
            	PushFollow(FOLLOW_expr_or_in_fieldlist2047);
            	idexp = expr_or();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	                                                                retval.listid.Add(id1.Text); 
            	                                                                retval.listexp.Add(idexp);
            	                                                           
            	}
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:332:28: ( COMA id2= ID IGUAL idexp2= expr_or )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == COMA) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:332:29: COMA id2= ID IGUAL idexp2= expr_or
            			    {
            			    	Match(input,COMA,FOLLOW_COMA_in_fieldlist2079); if (state.failed) return retval;
            			    	id2=(IToken)Match(input,ID,FOLLOW_ID_in_fieldlist2083); if (state.failed) return retval;
            			    	Match(input,IGUAL,FOLLOW_IGUAL_in_fieldlist2085); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_expr_or_in_fieldlist2089);
            			    	idexp2 = expr_or();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                                retval.listid.Add(id2.Text); 
            			    	                                                                retval.listexp.Add(idexp2);
            			    	                                                           
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fieldlist"


    // $ANTLR start "decllist"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:338:1: decllist returns [List<DeclarationNode> decl] : ( type_dec | var_dec | func_dec )* ;
    public List<DeclarationNode> decllist() // throws RecognitionException [1]
    {   
        List<DeclarationNode> decl = null;

        TypeDeclNode type_dec35 = null;

        VariableDeclNode var_dec36 = null;

        FunctionDeclNode func_dec37 = null;


        decl =  new List<DeclarationNode>();
        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:338:89: ( ( type_dec | var_dec | func_dec )* )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:339:36: ( type_dec | var_dec | func_dec )*
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:339:36: ( type_dec | var_dec | func_dec )*
            	do 
            	{
            	    int alt15 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case TYPE:
            	    	{
            	        alt15 = 1;
            	        }
            	        break;
            	    case VAR:
            	    	{
            	        alt15 = 2;
            	        }
            	        break;
            	    case FUNCTION:
            	    	{
            	        alt15 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:339:37: type_dec
            			    {
            			    	PushFollow(FOLLOW_type_dec_in_decllist2145);
            			    	type_dec35 = type_dec();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return decl;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                  decl.Add(type_dec35);
            			    	                                              
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:342:37: var_dec
            			    {
            			    	PushFollow(FOLLOW_var_dec_in_decllist2186);
            			    	var_dec36 = var_dec();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return decl;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                  decl.Add(var_dec36);
            			    	                                              
            			    	}

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:345:36: func_dec
            			    {
            			    	PushFollow(FOLLOW_func_dec_in_decllist2226);
            			    	func_dec37 = func_dec();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return decl;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	                                                  decl.Add(func_dec37);
            			    	                                              
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return decl;
    }
    // $ANTLR end "decllist"


    // $ANTLR start "type_dec"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:350:1: type_dec returns [TypeDeclNode typedec] : TYPE ID IGUAL type ;
    public TypeDeclNode type_dec() // throws RecognitionException [1]
    {   
        TypeDeclNode typedec = null;

        IToken ID39 = null;
        IToken TYPE40 = null;
        TypeDeclNode type38 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:350:40: ( TYPE ID IGUAL type )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:350:42: TYPE ID IGUAL type
            {
            	TYPE40=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_type_dec2242); if (state.failed) return typedec;
            	ID39=(IToken)Match(input,ID,FOLLOW_ID_in_type_dec2244); if (state.failed) return typedec;
            	Match(input,IGUAL,FOLLOW_IGUAL_in_type_dec2246); if (state.failed) return typedec;
            	PushFollow(FOLLOW_type_in_type_dec2248);
            	type38 = type();
            	state.followingStackPointer--;
            	if (state.failed) return typedec;
            	if ( (state.backtracking==0) )
            	{

            	                                                                typedec =  type38; 
            	  							      typedec.Id = ID39.Text;
            	  							      typedec.Col=TYPE40.CharPositionInLine; 
            	              						      typedec.Row = TYPE40.Line;
            	  							
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return typedec;
    }
    // $ANTLR end "type_dec"


    // $ANTLR start "type"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:358:1: type returns [TypeDeclNode typ] : (id1= ID | LLAV_A typefield LLAV_C | ARRAY OF id2= ID );
    public TypeDeclNode type() // throws RecognitionException [1]
    {   
        TypeDeclNode typ = null;

        IToken id1 = null;
        IToken id2 = null;
        IToken LLAV_A42 = null;
        IToken ARRAY43 = null;
        List<Parameter> typefield41 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:358:31: (id1= ID | LLAV_A typefield LLAV_C | ARRAY OF id2= ID )
            int alt16 = 3;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt16 = 1;
                }
                break;
            case LLAV_A:
            	{
                alt16 = 2;
                }
                break;
            case ARRAY:
            	{
                alt16 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return typ;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:358:33: id1= ID
                    {
                    	id1=(IToken)Match(input,ID,FOLLOW_ID_in_type2262); if (state.failed) return typ;
                    	if ( (state.backtracking==0) )
                    	{
                    	     
                    	                                          typ =  new TypeAliasNode("",id1.Text);
                    	  					typ.Col=id1.CharPositionInLine; 
                    	              				typ.Row = id1.Line;
                    	                                       
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:363:28: LLAV_A typefield LLAV_C
                    {
                    	LLAV_A42=(IToken)Match(input,LLAV_A,FOLLOW_LLAV_A_in_type2295); if (state.failed) return typ;
                    	PushFollow(FOLLOW_typefield_in_type2297);
                    	typefield41 = typefield();
                    	state.followingStackPointer--;
                    	if (state.failed) return typ;
                    	Match(input,LLAV_C,FOLLOW_LLAV_C_in_type2299); if (state.failed) return typ;
                    	if ( (state.backtracking==0) )
                    	{

                    	                                                         typ =  new TypeRecordNode("",typefield41);
                    	                                			       typ.Col=LLAV_A42.CharPositionInLine; 
                    	              					       typ.Row = LLAV_A42.Line;
                    	                                                     
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:368:28: ARRAY OF id2= ID
                    {
                    	ARRAY43=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_type2332); if (state.failed) return typ;
                    	Match(input,OF,FOLLOW_OF_in_type2334); if (state.failed) return typ;
                    	id2=(IToken)Match(input,ID,FOLLOW_ID_in_type2338); if (state.failed) return typ;
                    	if ( (state.backtracking==0) )
                    	{

                    	                                                 typ =  new TypeArrayNode("",id2.Text);
                    	                                                 typ.Col=ARRAY43.CharPositionInLine; 
                    	              				       typ.Row = ARRAY43.Line;
                    	                                             
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return typ;
    }
    // $ANTLR end "type"


    // $ANTLR start "typefield"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:375:1: typefield returns [List<Parameter> typ] : (id1= type_f ( COMA id2= type_f )* )? ;
    public List<Parameter> typefield() // throws RecognitionException [1]
    {   
        List<Parameter> typ = null;

        Parameter id1 = null;

        Parameter id2 = null;


        typ =  new List<Parameter>();
        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:375:76: ( (id1= type_f ( COMA id2= type_f )* )? )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:376:34: (id1= type_f ( COMA id2= type_f )* )?
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:376:34: (id1= type_f ( COMA id2= type_f )* )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == ID) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:376:35: id1= type_f ( COMA id2= type_f )*
            	        {
            	        	PushFollow(FOLLOW_type_f_in_typefield2392);
            	        	id1 = type_f();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return typ;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   
            	        	                                                  typ.Add(id1);
            	        	                                             
            	        	}
            	        	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:379:28: ( COMA id2= type_f )*
            	        	do 
            	        	{
            	        	    int alt17 = 2;
            	        	    int LA17_0 = input.LA(1);

            	        	    if ( (LA17_0 == COMA) )
            	        	    {
            	        	        alt17 = 1;
            	        	    }


            	        	    switch (alt17) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:379:29: COMA id2= type_f
            	        			    {
            	        			    	Match(input,COMA,FOLLOW_COMA_in_typefield2423); if (state.failed) return typ;
            	        			    	PushFollow(FOLLOW_type_f_in_typefield2427);
            	        			    	id2 = type_f();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return typ;
            	        			    	if ( (state.backtracking==0) )
            	        			    	{

            	        			    	                                                  typ.Add(id2);
            	        			    	                                             
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop17;
            	        	    }
            	        	} while (true);

            	        	loop17:
            	        		;	// Stops C# compiler whining that label 'loop17' has no statements


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return typ;
    }
    // $ANTLR end "typefield"


    // $ANTLR start "type_f"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:384:1: type_f returns [Parameter typ] : id1= ID DOSPTO id2= ID ;
    public Parameter type_f() // throws RecognitionException [1]
    {   
        Parameter typ = null;

        IToken id1 = null;
        IToken id2 = null;

        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:384:33: (id1= ID DOSPTO id2= ID )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:384:35: id1= ID DOSPTO id2= ID
            {
            	id1=(IToken)Match(input,ID,FOLLOW_ID_in_type_f2448); if (state.failed) return typ;
            	Match(input,DOSPTO,FOLLOW_DOSPTO_in_type_f2450); if (state.failed) return typ;
            	id2=(IToken)Match(input,ID,FOLLOW_ID_in_type_f2454); if (state.failed) return typ;
            	if ( (state.backtracking==0) )
            	{
            	   
            	                                                             typ =  new Parameter(id1.Text,id2.Text);
            	  							   
            	  						       
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return typ;
    }
    // $ANTLR end "type_f"


    // $ANTLR start "var_dec"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:390:1: var_dec returns [VariableDeclNode vardec] : VAR id1= ID ( ASIG idexpr1= expr_or | DOSPTO id2= ID ASIG idexpr2= expr_or ) ;
    public VariableDeclNode var_dec() // throws RecognitionException [1]
    {   
        VariableDeclNode vardec = null;

        IToken id1 = null;
        IToken id2 = null;
        IToken VAR44 = null;
        TigerNode idexpr1 = null;

        TigerNode idexpr2 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:390:43: ( VAR id1= ID ( ASIG idexpr1= expr_or | DOSPTO id2= ID ASIG idexpr2= expr_or ) )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:390:45: VAR id1= ID ( ASIG idexpr1= expr_or | DOSPTO id2= ID ASIG idexpr2= expr_or )
            {
            	VAR44=(IToken)Match(input,VAR,FOLLOW_VAR_in_var_dec2469); if (state.failed) return vardec;
            	id1=(IToken)Match(input,ID,FOLLOW_ID_in_var_dec2473); if (state.failed) return vardec;
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:391:23: ( ASIG idexpr1= expr_or | DOSPTO id2= ID ASIG idexpr2= expr_or )
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == ASIG) )
            	{
            	    alt19 = 1;
            	}
            	else if ( (LA19_0 == DOSPTO) )
            	{
            	    alt19 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return vardec;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:391:24: ASIG idexpr1= expr_or
            	        {
            	        	Match(input,ASIG,FOLLOW_ASIG_in_var_dec2498); if (state.failed) return vardec;
            	        	PushFollow(FOLLOW_expr_or_in_var_dec2502);
            	        	idexpr1 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return vardec;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   
            	        	                                              vardec =  new VariableDeclNode(id1.Text,idexpr1);
            	        	                        			    vardec.Col=VAR44.CharPositionInLine; 
            	        	                                              vardec.Row = VAR44.Line;
            	        	                        			
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:396:17: DOSPTO id2= ID ASIG idexpr2= expr_or
            	        {
            	        	Match(input,DOSPTO,FOLLOW_DOSPTO_in_var_dec2522); if (state.failed) return vardec;
            	        	id2=(IToken)Match(input,ID,FOLLOW_ID_in_var_dec2526); if (state.failed) return vardec;
            	        	Match(input,ASIG,FOLLOW_ASIG_in_var_dec2528); if (state.failed) return vardec;
            	        	PushFollow(FOLLOW_expr_or_in_var_dec2532);
            	        	idexpr2 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return vardec;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	                                                       vardec =  new VariableDeclNode(id1.Text,id2.Text,idexpr2);
            	        	                        				     vardec.Col=VAR44.CharPositionInLine; 
            	        	              				             vardec.Row = VAR44.Line;
            	        	                        				
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return vardec;
    }
    // $ANTLR end "var_dec"


    // $ANTLR start "func_dec"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:403:1: func_dec returns [FunctionDeclNode funcdec] : FUNCTION id1= ID PAR_A typefield PAR_C (idi= IGUAL idexpr1= expr_or | DOSPTO id2= ID IGUAL idexpr2= expr_or ) ;
    public FunctionDeclNode func_dec() // throws RecognitionException [1]
    {   
        FunctionDeclNode funcdec = null;

        IToken id1 = null;
        IToken idi = null;
        IToken id2 = null;
        TigerNode idexpr1 = null;

        TigerNode idexpr2 = null;

        List<Parameter> typefield45 = null;


        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:403:44: ( FUNCTION id1= ID PAR_A typefield PAR_C (idi= IGUAL idexpr1= expr_or | DOSPTO id2= ID IGUAL idexpr2= expr_or ) )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:403:46: FUNCTION id1= ID PAR_A typefield PAR_C (idi= IGUAL idexpr1= expr_or | DOSPTO id2= ID IGUAL idexpr2= expr_or )
            {
            	Match(input,FUNCTION,FOLLOW_FUNCTION_in_func_dec2547); if (state.failed) return funcdec;
            	id1=(IToken)Match(input,ID,FOLLOW_ID_in_func_dec2551); if (state.failed) return funcdec;
            	Match(input,PAR_A,FOLLOW_PAR_A_in_func_dec2553); if (state.failed) return funcdec;
            	PushFollow(FOLLOW_typefield_in_func_dec2555);
            	typefield45 = typefield();
            	state.followingStackPointer--;
            	if (state.failed) return funcdec;
            	Match(input,PAR_C,FOLLOW_PAR_C_in_func_dec2557); if (state.failed) return funcdec;
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:404:25: (idi= IGUAL idexpr1= expr_or | DOSPTO id2= ID IGUAL idexpr2= expr_or )
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == IGUAL) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == DOSPTO) )
            	{
            	    alt20 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return funcdec;}
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:404:27: idi= IGUAL idexpr1= expr_or
            	        {
            	        	idi=(IToken)Match(input,IGUAL,FOLLOW_IGUAL_in_func_dec2587); if (state.failed) return funcdec;
            	        	PushFollow(FOLLOW_expr_or_in_func_dec2591);
            	        	idexpr1 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return funcdec;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	                                                       funcdec =  new FunctionDeclNode(id1.Text,typefield45,idexpr1);
            	        	                                                       funcdec.Col = idi.CharPositionInLine; 
            	        	              					     funcdec.Row = idi.Line;
            	        	                                                  
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:409:17: DOSPTO id2= ID IGUAL idexpr2= expr_or
            	        {
            	        	Match(input,DOSPTO,FOLLOW_DOSPTO_in_func_dec2611); if (state.failed) return funcdec;
            	        	id2=(IToken)Match(input,ID,FOLLOW_ID_in_func_dec2615); if (state.failed) return funcdec;
            	        	Match(input,IGUAL,FOLLOW_IGUAL_in_func_dec2617); if (state.failed) return funcdec;
            	        	PushFollow(FOLLOW_expr_or_in_func_dec2621);
            	        	idexpr2 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return funcdec;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	                                                       funcdec =  new FunctionDeclNode(id1.Text,id2.Text,typefield45,idexpr2);
            	        	                                                       funcdec.Col = id2.CharPositionInLine; 
            	        	              					     funcdec.Row = id2.Line;
            	        	                                                  
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return funcdec;
    }
    // $ANTLR end "func_dec"


    // $ANTLR start "exprseq"
    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:416:1: exprseq returns [List<TigerNode> seq] : (id1= expr_or ( PTOCOM id2= expr_or )* )? ;
    public List<TigerNode> exprseq() // throws RecognitionException [1]
    {   
        List<TigerNode> seq = null;

        TigerNode id1 = null;

        TigerNode id2 = null;


        seq =  new List<TigerNode>();
        try 
    	{
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:416:75: ( (id1= expr_or ( PTOCOM id2= expr_or )* )? )
            // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:417:37: (id1= expr_or ( PTOCOM id2= expr_or )* )?
            {
            	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:417:37: (id1= expr_or ( PTOCOM id2= expr_or )* )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == MENOS || LA22_0 == NIL || LA22_0 == PAR_A || LA22_0 == IF || LA22_0 == WHILE || LA22_0 == FOR || (LA22_0 >= BREAK && LA22_0 <= LET) || (LA22_0 >= STR && LA22_0 <= ID)) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:417:38: id1= expr_or ( PTOCOM id2= expr_or )*
            	        {
            	        	PushFollow(FOLLOW_expr_or_in_exprseq2679);
            	        	id1 = expr_or();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return seq;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	                                                      seq.Add(id1);
            	        	                                                  
            	        	}
            	        	// C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:420:30: ( PTOCOM id2= expr_or )*
            	        	do 
            	        	{
            	        	    int alt21 = 2;
            	        	    int LA21_0 = input.LA(1);

            	        	    if ( (LA21_0 == PTOCOM) )
            	        	    {
            	        	        alt21 = 1;
            	        	    }


            	        	    switch (alt21) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:420:31: PTOCOM id2= expr_or
            	        			    {
            	        			    	Match(input,PTOCOM,FOLLOW_PTOCOM_in_exprseq2713); if (state.failed) return seq;
            	        			    	PushFollow(FOLLOW_expr_or_in_exprseq2717);
            	        			    	id2 = expr_or();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return seq;
            	        			    	if ( (state.backtracking==0) )
            	        			    	{

            	        			    	                                                      seq.Add(id2);
            	        			    	                                                  
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop21;
            	        	    }
            	        	} while (true);

            	        	loop21:
            	        		;	// Stops C# compiler whining that label 'loop21' has no statements


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return seq;
    }
    // $ANTLR end "exprseq"

    // $ANTLR start "synpred1_tiger_grammar"
    public void synpred1_tiger_grammar_fragment() {
        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:181:24: ( COR_A expr_or COR_C OF )
        // C:\\Users\\Danaice\\Desktop\\lastversion\\Dany_gramatica tiger ANTLR oficial\\tiger_grammar.g:181:25: COR_A expr_or COR_C OF
        {
        	Match(input,COR_A,FOLLOW_COR_A_in_synpred1_tiger_grammar1234); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_or_in_synpred1_tiger_grammar1236);
        	expr_or();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,COR_C,FOLLOW_COR_C_in_synpred1_tiger_grammar1238); if (state.failed) return ;
        	Match(input,OF,FOLLOW_OF_in_synpred1_tiger_grammar1240); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_tiger_grammar"

    // Delegated rules

   	public bool synpred1_tiger_grammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_tiger_grammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
	    this.dfa7.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA7_SpecialStateTransition);
	}

    const string DFA7_eotS =
        "\x22\uffff";
    const string DFA7_eofS =
        "\x01\x02\x21\uffff";
    const string DFA7_minS =
        "\x01\x04\x01\x00\x20\uffff";
    const string DFA7_maxS =
        "\x01\x2b\x01\x00\x20\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x02\x1c\uffff\x01\x03\x01\x04\x01\x01";
    const string DFA7_specialS =
        "\x01\uffff\x01\x00\x20\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x0c\x02\x02\uffff\x01\x02\x01\x20\x02\x02\x01\x01\x01\x02"+
            "\x01\x1f\x03\x02\x02\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff"+
            "\x01\x02\x02\uffff\x04\x02\x01\uffff\x01\x02",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "180:20: ( ( COR_A expr_or COR_C OF )=> COR_A idexp1= expr_or COR_C OF idexp= expr_or | idp4= ptocor ida1= asig | LLAV_A fieldlist LLAV_C idp1= ptocor | PAR_A exprlist PAR_C idp3= ptocor )"; }
        }

    }


    protected internal int DFA7_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA7_1 = input.LA(1);

                   	 
                   	int index7_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_tiger_grammar()) ) { s = 33; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index7_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae7 =
            new NoViableAltException(dfa.Description, 7, _s, input);
        dfa.Error(nvae7);
        throw nvae7;
    }
 

    public static readonly BitSet FOLLOW_expr_or_in_language526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EOF_in_language529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_and_in_expr_or542 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_OR_in_expr_or571 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_and_in_expr_or576 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_expr_comp_in_expr_and631 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_AND_in_expr_and661 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_comp_in_expr_and665 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp684 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_IGUAL_in_expr_comp742 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp746 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_MAYOR_in_expr_comp768 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp772 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_MENOR_in_expr_comp805 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp809 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_DIST_in_expr_comp841 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp845 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_MENIG_in_expr_comp879 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp883 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_MAYIG_in_expr_comp916 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_pm_in_expr_comp920 = new BitSet(new ulong[]{0x0000000000007E02UL});
    public static readonly BitSet FOLLOW_expr_dm_in_expr_pm938 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_MAS_in_expr_pm971 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_dm_in_expr_pm975 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_MENOS_in_expr_pm1009 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_dm_in_expr_pm1013 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_expr_in_expr_dm1033 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_MULT_in_expr_dm1073 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_in_expr_dm1077 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_DIV_in_expr_dm1118 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_in_expr_dm1122 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_STR_in_expr1153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr1172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr1204 = new BitSet(new ulong[]{0x0000000001488100UL});
    public static readonly BitSet FOLLOW_COR_A_in_expr1245 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1249 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_COR_C_in_expr1251 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_OF_in_expr1253 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ptocor_in_expr1318 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_asig_in_expr1322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LLAV_A_in_expr1349 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_fieldlist_in_expr1351 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LLAV_C_in_expr1353 = new BitSet(new ulong[]{0x0000000000408000UL});
    public static readonly BitSet FOLLOW_ptocor_in_expr1357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PAR_A_in_expr1382 = new BitSet(new ulong[]{0x00007035201A0020UL});
    public static readonly BitSet FOLLOW_exprlist_in_expr1384 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_PAR_C_in_expr1386 = new BitSet(new ulong[]{0x0000000000408000UL});
    public static readonly BitSet FOLLOW_ptocor_in_expr1390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MENOS_in_expr1446 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BREAK_in_expr1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NIL_in_expr1508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PAR_A_in_expr1538 = new BitSet(new ulong[]{0x00007035201A0020UL});
    public static readonly BitSet FOLLOW_exprseq_in_expr1540 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_PAR_C_in_expr1542 = new BitSet(new ulong[]{0x0000000000408000UL});
    public static readonly BitSet FOLLOW_ptocor_in_expr1546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr1577 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1581 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_THEN_in_expr1583 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1587 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_ifthenelse_in_expr1589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1627 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1631 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_DO_in_expr1633 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1665 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_expr1669 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASIG_in_expr1671 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1675 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_TO_in_expr1677 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1681 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_DO_in_expr1683 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_expr1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LET_in_expr1716 = new BitSet(new ulong[]{0x00000B4000000000UL});
    public static readonly BitSet FOLLOW_decllist_in_expr1718 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_IN_in_expr1720 = new BitSet(new ulong[]{0x000070B5200A0020UL});
    public static readonly BitSet FOLLOW_exprseq_in_expr1722 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_END_in_expr1725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PTO_in_ptocor1785 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_ptocor1789 = new BitSet(new ulong[]{0x0000000000408002UL});
    public static readonly BitSet FOLLOW_COR_A_in_ptocor1828 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_ptocor1830 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_COR_C_in_ptocor1832 = new BitSet(new ulong[]{0x0000000000408002UL});
    public static readonly BitSet FOLLOW_ASIG_in_asig1848 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_asig1850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_ifthenelse1865 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_ifthenelse1867 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_or_in_exprlist1935 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_COMA_in_exprlist1979 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_exprlist1983 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_ID_in_fieldlist2041 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_IGUAL_in_fieldlist2043 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_fieldlist2047 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_COMA_in_fieldlist2079 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_fieldlist2083 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_IGUAL_in_fieldlist2085 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_fieldlist2089 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_type_dec_in_decllist2145 = new BitSet(new ulong[]{0x00000B0000000002UL});
    public static readonly BitSet FOLLOW_var_dec_in_decllist2186 = new BitSet(new ulong[]{0x00000B0000000002UL});
    public static readonly BitSet FOLLOW_func_dec_in_decllist2226 = new BitSet(new ulong[]{0x00000B0000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_type_dec2242 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_type_dec2244 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_IGUAL_in_type_dec2246 = new BitSet(new ulong[]{0x0000440001000000UL});
    public static readonly BitSet FOLLOW_type_in_type_dec2248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_type2262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LLAV_A_in_type2295 = new BitSet(new ulong[]{0x0000400002000000UL});
    public static readonly BitSet FOLLOW_typefield_in_type2297 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LLAV_C_in_type2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_type2332 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_OF_in_type2334 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_type2338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_f_in_typefield2392 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_COMA_in_typefield2423 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_type_f_in_typefield2427 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_ID_in_type_f2448 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_DOSPTO_in_type_f2450 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_type_f2454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_var_dec2469 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_var_dec2473 = new BitSet(new ulong[]{0x0000000000010100UL});
    public static readonly BitSet FOLLOW_ASIG_in_var_dec2498 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_var_dec2502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOSPTO_in_var_dec2522 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_var_dec2526 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASIG_in_var_dec2528 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_var_dec2532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_func_dec2547 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_func_dec2551 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_PAR_A_in_func_dec2553 = new BitSet(new ulong[]{0x0000400000100000UL});
    public static readonly BitSet FOLLOW_typefield_in_func_dec2555 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_PAR_C_in_func_dec2557 = new BitSet(new ulong[]{0x0000000000010200UL});
    public static readonly BitSet FOLLOW_IGUAL_in_func_dec2587 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_func_dec2591 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOSPTO_in_func_dec2611 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_func_dec2615 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_IGUAL_in_func_dec2617 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_func_dec2621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_or_in_exprseq2679 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_PTOCOM_in_exprseq2713 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_exprseq2717 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_COR_A_in_synpred1_tiger_grammar1234 = new BitSet(new ulong[]{0x00007035200A0020UL});
    public static readonly BitSet FOLLOW_expr_or_in_synpred1_tiger_grammar1236 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_COR_C_in_synpred1_tiger_grammar1238 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_OF_in_synpred1_tiger_grammar1240 = new BitSet(new ulong[]{0x0000000000000002UL});

}
