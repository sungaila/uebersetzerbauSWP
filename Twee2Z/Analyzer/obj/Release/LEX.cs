//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.4.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\David\Desktop\SWP\uebersetzerbauSWP\Twee2Z\Analyzer\LEX.g4 by ANTLR 4.4.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Twee2Z.Analyzer {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.4.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class LEX : Lexer {
	public const int
		INT=1, PASS=2, MACRO_START=3, LINK_START=4, FUNC_START=5, VAR_NAME=6, 
		FORMAT=7, EXCLUDE=8, NEW_LINE=9, STRING_START=10, STRING_START2=11, SPACE=12, 
		WORD=13, STRING=14, PMODEWORD=15, TAG=16, TAG_BEGIN=17, TAG_END=18, PMODE_END=19, 
		STRING_BODY=20, STRING_END=21, STRING_BODY2=22, STRING_END2=23, FUNC_NAME=24, 
		FUNC_BRACKET_OPEN=25, FUNC_BRACKET_CLOSE=26, IF=27, ELSE_IF=28, ELSE=29, 
		ENDIF=30, NOBR=31, ENDNOBR=32, SILENTLY=33, ENDSILENTLY=34, ACTIONS=35, 
		CHOICE=36, DISPLAY=37, SET=38, PRINT=39, MACRO_BRACKET_OPEN=40, MACRO_END=41, 
		EXPRESSION=42, EXPRESSION_BODY=43, TEST=44, EXP_END_M=45, FUNC_LINK=46, 
		PIPE=47, SQ_BRACKET_CLOSE=48, SQ_BRACKET_OPEN=49, WORDS=50, LINK_END=51;
	public const int PMode = 1;
	public const int SMode = 2;
	public const int SMode2 = 3;
	public const int FMode = 4;
	public const int MMode = 5;
	public const int EMode = 6;
	public const int LMode = 7;
	public static string[] modeNames = {
		"DEFAULT_MODE", "PMode", "SMode", "SMode2", "FMode", "MMode", "EMode", 
		"LMode"
	};

	public static readonly string[] ruleNames = {
		"INT", "PASS", "MACRO_START", "LINK_START", "FUNC_START", "VAR_NAME", 
		"FORMAT", "EXCLUDE", "NEW_LINE", "STRING_START", "STRING_START2", "SPACE", 
		"WORD", "STRING", "LETTER", "DIGIT", "DOUBLE_DOT", "EXCLAMATION_MARK", 
		"POINT", "COMMA", "SEMICOLON", "LOW_LINE", "QUOTE", "QUOTE2", "DOLLAR", 
		"PMODEWORD", "TAG", "TAG_BEGIN", "TAG_END", "PMODE_END", "STRING_BODY", 
		"STRING_END", "STRING_BODY2", "STRING_END2", "FUNC_NAME", "FUNC_BRACKET_OPEN", 
		"FUNC_BRACKET_CLOSE", "IF", "ELSE_IF", "ELSE", "ENDIF", "NOBR", "ENDNOBR", 
		"SILENTLY", "ENDSILENTLY", "ACTIONS", "CHOICE", "DISPLAY", "SET", "PRINT", 
		"MACRO_BRACKET_OPEN", "MACRO_END", "EXPRESSION", "EXPRESSION_BODY", "TEST", 
		"EXP_END_M", "FUNC_LINK", "PIPE", "SQ_BRACKET_CLOSE", "SQ_BRACKET_OPEN", 
		"WORDS", "LINK_END"
	};


	public LEX(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'[['", null, null, null, null, null, null, null, 
		"' '", null, null, null, null, null, null, null, null, null, null, null, 
		null, "'('", "')'", "'if'", "'else if'", null, null, null, null, null, 
		null, null, null, "'display'", "'set'", "'print'", "'<<'", null, null, 
		null, null, null, null, "'|'", null, null, null, "']]'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INT", "PASS", "MACRO_START", "LINK_START", "FUNC_START", "VAR_NAME", 
		"FORMAT", "EXCLUDE", "NEW_LINE", "STRING_START", "STRING_START2", "SPACE", 
		"WORD", "STRING", "PMODEWORD", "TAG", "TAG_BEGIN", "TAG_END", "PMODE_END", 
		"STRING_BODY", "STRING_END", "STRING_BODY2", "STRING_END2", "FUNC_NAME", 
		"FUNC_BRACKET_OPEN", "FUNC_BRACKET_CLOSE", "IF", "ELSE_IF", "ELSE", "ENDIF", 
		"NOBR", "ENDNOBR", "SILENTLY", "ENDSILENTLY", "ACTIONS", "CHOICE", "DISPLAY", 
		"SET", "PRINT", "MACRO_BRACKET_OPEN", "MACRO_END", "EXPRESSION", "EXPRESSION_BODY", 
		"TEST", "EXP_END_M", "FUNC_LINK", "PIPE", "SQ_BRACKET_CLOSE", "SQ_BRACKET_OPEN", 
		"WORDS", "LINK_END"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "LEX.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x35\x274\b\x1\b"+
		"\x1\b\x1\b\x1\b\x1\b\x1\b\x1\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4"+
		"\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f"+
		"\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12\t"+
		"\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x4\x17\t\x17"+
		"\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D"+
		"\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$"+
		"\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4."+
		"\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32\t\x32\x4\x33\t\x33\x4\x34"+
		"\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37\x4\x38\t\x38\x4\x39\t\x39"+
		"\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4?\t?\x3\x2\x6\x2\x88\n\x2\r\x2\xE"+
		"\x2\x89\x3\x3\x3\x3\x3\x3\x6\x3\x8F\n\x3\r\x3\xE\x3\x90\x3\x3\x3\x3\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6"+
		"\x3\x6\x3\a\x3\a\x3\a\x5\a\xA5\n\a\x3\a\x3\a\x3\a\a\a\xAA\n\a\f\a\xE\a"+
		"\xAD\v\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\b\xC5\n\b\x3\t\x3\t"+
		"\x3\n\x3\n\x3\n\x5\n\xCC\n\n\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3"+
		"\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x5"+
		"\xF\xE2\n\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\a\x1B\xFB\n\x1B\f\x1B\xE\x1B\xFE\v\x1B"+
		"\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x6\x1B\x106\n\x1B\r\x1B\xE"+
		"\x1B\x107\x3\x1B\a\x1B\x10B\n\x1B\f\x1B\xE\x1B\x10E\v\x1B\x6\x1B\x110"+
		"\n\x1B\r\x1B\xE\x1B\x111\x3\x1C\x3\x1C\x3\x1C\a\x1C\x117\n\x1C\f\x1C\xE"+
		"\x1C\x11A\v\x1C\x3\x1C\x3\x1C\x6\x1C\x11E\n\x1C\r\x1C\xE\x1C\x11F\x3\x1C"+
		"\a\x1C\x123\n\x1C\f\x1C\xE\x1C\x126\v\x1C\a\x1C\x128\n\x1C\f\x1C\xE\x1C"+
		"\x12B\v\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\a\x1F\x134"+
		"\n\x1F\f\x1F\xE\x1F\x137\v\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \a \x13E"+
		"\n \f \xE \x141\v \x3!\x3!\x3!\x3!\x3\"\a\"\x148\n\"\f\"\xE\"\x14B\v\""+
		"\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3"+
		"$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$"+
		"\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x3$\x5$\x180"+
		"\n$\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3&\x3\'\x3\'\x3\'\x3\'\x3\'\x3(\x3(\x3"+
		"(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3)\x3)\x3)\x3)\x3)\x3)\x3)\a)\x1A0\n)\f"+
		")\xE)\x1A3\v)\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\a*\x1AD\n*\f*\xE*\x1B0\v"+
		"*\x3+\x3+\x3+\x3+\x3+\x3+\x3+\a+\x1B9\n+\f+\xE+\x1BC\v+\x3,\x3,\x3,\x3"+
		",\x3,\x3,\x3,\x3,\x3,\x3,\a,\x1C8\n,\f,\xE,\x1CB\v,\x3-\x3-\x3-\x3-\x3"+
		"-\x3-\x3-\x3-\x3-\x3-\x3-\a-\x1D8\n-\f-\xE-\x1DB\v-\x3.\x3.\x3.\x3.\x3"+
		".\x3.\x3.\x3.\x3.\x3.\x3.\x3.\x3.\x3.\a.\x1EB\n.\f.\xE.\x1EE\v.\x3/\x3"+
		"/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\a/\x1FA\n/\f/\xE/\x1FD\v/\x3\x30\x3"+
		"\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\a\x30\x208\n\x30"+
		"\f\x30\xE\x30\x20B\v\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3"+
		"\x31\x3\x31\x3\x31\x3\x31\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3"+
		"\x33\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x3\x34\x3\x34\x3"+
		"\x34\x3\x35\x3\x35\x3\x35\x3\x35\x3\x35\x3\x36\x3\x36\x3\x36\x3\x36\x3"+
		"\x36\x3\x37\x3\x37\x3\x37\x3\x37\x3\x37\x3\x37\x3\x37\x5\x37\x239\n\x37"+
		"\x3\x38\x3\x38\x3\x38\x5\x38\x23E\n\x38\x3\x39\x3\x39\x3\x39\x3\x39\x3"+
		"\x39\x3\x39\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3"+
		":\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x3:\x5:\x260\n:\x3;\x3;\x3<"+
		"\x3<\x3=\x3=\x3=\x3=\x3>\x3>\x6>\x26C\n>\r>\xE>\x26D\x3?\x3?\x3?\x3?\x3"+
		"?\x4\x13F\x149\x2\x2@\n\x2\x3\f\x2\x4\xE\x2\x5\x10\x2\x6\x12\x2\a\x14"+
		"\x2\b\x16\x2\t\x18\x2\n\x1A\x2\v\x1C\x2\f\x1E\x2\r \x2\xE\"\x2\xF$\x2"+
		"\x10&\x2\x2(\x2\x2*\x2\x2,\x2\x2.\x2\x2\x30\x2\x2\x32\x2\x2\x34\x2\x2"+
		"\x36\x2\x2\x38\x2\x2:\x2\x2<\x2\x11>\x2\x12@\x2\x13\x42\x2\x14\x44\x2"+
		"\x15\x46\x2\x16H\x2\x17J\x2\x18L\x2\x19N\x2\x1AP\x2\x1BR\x2\x1CT\x2\x1D"+
		"V\x2\x1EX\x2\x1FZ\x2 \\\x2!^\x2\"`\x2#\x62\x2$\x64\x2%\x66\x2&h\x2\'j"+
		"\x2(l\x2)n\x2*p\x2+r\x2,t\x2-v\x2.x\x2/z\x2\x30|\x2\x31~\x2\x32\x80\x2"+
		"\x33\x82\x2\x34\x84\x2\x35\n\x2\x3\x4\x5\x6\a\b\t\t\v\x2\'\'))\x31\x31"+
		"<<??]]_\x61}}\x7F\x80\x4\x2\f\f\xF\xF\r\x2\f\f\xF\xF\"\"$$\'\'))\x31<"+
		"??]]_\x61}\x80\x4\x2\x43\\\x63|\x3\x2\x32;\x4\x2\x30\x30\x61\x61\x3\x2"+
		"@@\x29F\x2\n\x3\x2\x2\x2\x2\f\x3\x2\x2\x2\x2\xE\x3\x2\x2\x2\x2\x10\x3"+
		"\x2\x2\x2\x2\x12\x3\x2\x2\x2\x2\x14\x3\x2\x2\x2\x2\x16\x3\x2\x2\x2\x2"+
		"\x18\x3\x2\x2\x2\x2\x1A\x3\x2\x2\x2\x2\x1C\x3\x2\x2\x2\x2\x1E\x3\x2\x2"+
		"\x2\x2 \x3\x2\x2\x2\x2\"\x3\x2\x2\x2\x2$\x3\x2\x2\x2\x3<\x3\x2\x2\x2\x3"+
		">\x3\x2\x2\x2\x3@\x3\x2\x2\x2\x3\x42\x3\x2\x2\x2\x3\x44\x3\x2\x2\x2\x4"+
		"\x46\x3\x2\x2\x2\x4H\x3\x2\x2\x2\x5J\x3\x2\x2\x2\x5L\x3\x2\x2\x2\x6N\x3"+
		"\x2\x2\x2\x6P\x3\x2\x2\x2\x6R\x3\x2\x2\x2\aT\x3\x2\x2\x2\aV\x3\x2\x2\x2"+
		"\aX\x3\x2\x2\x2\aZ\x3\x2\x2\x2\a\\\x3\x2\x2\x2\a^\x3\x2\x2\x2\a`\x3\x2"+
		"\x2\x2\a\x62\x3\x2\x2\x2\a\x64\x3\x2\x2\x2\a\x66\x3\x2\x2\x2\ah\x3\x2"+
		"\x2\x2\aj\x3\x2\x2\x2\al\x3\x2\x2\x2\an\x3\x2\x2\x2\ap\x3\x2\x2\x2\br"+
		"\x3\x2\x2\x2\bt\x3\x2\x2\x2\bv\x3\x2\x2\x2\bx\x3\x2\x2\x2\tz\x3\x2\x2"+
		"\x2\t|\x3\x2\x2\x2\t~\x3\x2\x2\x2\t\x80\x3\x2\x2\x2\t\x82\x3\x2\x2\x2"+
		"\t\x84\x3\x2\x2\x2\n\x87\x3\x2\x2\x2\f\x8B\x3\x2\x2\x2\xE\x94\x3\x2\x2"+
		"\x2\x10\x98\x3\x2\x2\x2\x12\x9D\x3\x2\x2\x2\x14\xA1\x3\x2\x2\x2\x16\xC4"+
		"\x3\x2\x2\x2\x18\xC6\x3\x2\x2\x2\x1A\xCB\x3\x2\x2\x2\x1C\xCD\x3\x2\x2"+
		"\x2\x1E\xD1\x3\x2\x2\x2 \xD5\x3\x2\x2\x2\"\xD7\x3\x2\x2\x2$\xE1\x3\x2"+
		"\x2\x2&\xE3\x3\x2\x2\x2(\xE5\x3\x2\x2\x2*\xE7\x3\x2\x2\x2,\xE9\x3\x2\x2"+
		"\x2.\xEB\x3\x2\x2\x2\x30\xED\x3\x2\x2\x2\x32\xEF\x3\x2\x2\x2\x34\xF1\x3"+
		"\x2\x2\x2\x36\xF3\x3\x2\x2\x2\x38\xF5\x3\x2\x2\x2:\xF7\x3\x2\x2\x2<\xFC"+
		"\x3\x2\x2\x2>\x113\x3\x2\x2\x2@\x12E\x3\x2\x2\x2\x42\x130\x3\x2\x2\x2"+
		"\x44\x135\x3\x2\x2\x2\x46\x13F\x3\x2\x2\x2H\x142\x3\x2\x2\x2J\x149\x3"+
		"\x2\x2\x2L\x14C\x3\x2\x2\x2N\x17F\x3\x2\x2\x2P\x181\x3\x2\x2\x2R\x185"+
		"\x3\x2\x2\x2T\x189\x3\x2\x2\x2V\x18E\x3\x2\x2\x2X\x198\x3\x2\x2\x2Z\x1A4"+
		"\x3\x2\x2\x2\\\x1B1\x3\x2\x2\x2^\x1BD\x3\x2\x2\x2`\x1CC\x3\x2\x2\x2\x62"+
		"\x1DC\x3\x2\x2\x2\x64\x1EF\x3\x2\x2\x2\x66\x1FE\x3\x2\x2\x2h\x20C\x3\x2"+
		"\x2\x2j\x216\x3\x2\x2\x2l\x21C\x3\x2\x2\x2n\x224\x3\x2\x2\x2p\x227\x3"+
		"\x2\x2\x2r\x22C\x3\x2\x2\x2t\x238\x3\x2\x2\x2v\x23D\x3\x2\x2\x2x\x23F"+
		"\x3\x2\x2\x2z\x25F\x3\x2\x2\x2|\x261\x3\x2\x2\x2~\x263\x3\x2\x2\x2\x80"+
		"\x265\x3\x2\x2\x2\x82\x26B\x3\x2\x2\x2\x84\x26F\x3\x2\x2\x2\x86\x88\x5"+
		"(\x11\x2\x87\x86\x3\x2\x2\x2\x88\x89\x3\x2\x2\x2\x89\x87\x3\x2\x2\x2\x89"+
		"\x8A\x3\x2\x2\x2\x8A\v\x3\x2\x2\x2\x8B\x8C\x5\x1A\n\x2\x8C\x8E\a<\x2\x2"+
		"\x8D\x8F\a<\x2\x2\x8E\x8D\x3\x2\x2\x2\x8F\x90\x3\x2\x2\x2\x90\x8E\x3\x2"+
		"\x2\x2\x90\x91\x3\x2\x2\x2\x91\x92\x3\x2\x2\x2\x92\x93\b\x3\x2\x2\x93"+
		"\r\x3\x2\x2\x2\x94\x95\x5n\x34\x2\x95\x96\x3\x2\x2\x2\x96\x97\b\x4\x3"+
		"\x2\x97\xF\x3\x2\x2\x2\x98\x99\a]\x2\x2\x99\x9A\a]\x2\x2\x9A\x9B\x3\x2"+
		"\x2\x2\x9B\x9C\b\x5\x4\x2\x9C\x11\x3\x2\x2\x2\x9D\x9E\x5N$\x2\x9E\x9F"+
		"\x3\x2\x2\x2\x9F\xA0\b\x6\x5\x2\xA0\x13\x3\x2\x2\x2\xA1\xA4\x5:\x1A\x2"+
		"\xA2\xA5\x5&\x10\x2\xA3\xA5\x5\x34\x17\x2\xA4\xA2\x3\x2\x2\x2\xA4\xA3"+
		"\x3\x2\x2\x2\xA5\xAB\x3\x2\x2\x2\xA6\xAA\x5&\x10\x2\xA7\xAA\x5(\x11\x2"+
		"\xA8\xAA\x5\x34\x17\x2\xA9\xA6\x3\x2\x2\x2\xA9\xA7\x3\x2\x2\x2\xA9\xA8"+
		"\x3\x2\x2\x2\xAA\xAD\x3\x2\x2\x2\xAB\xA9\x3\x2\x2\x2\xAB\xAC\x3\x2\x2"+
		"\x2\xAC\x15\x3\x2\x2\x2\xAD\xAB\x3\x2\x2\x2\xAE\xAF\a)\x2\x2\xAF\xC5\a"+
		")\x2\x2\xB0\xB1\a\x31\x2\x2\xB1\xC5\a\x31\x2\x2\xB2\xB3\a\x61\x2\x2\xB3"+
		"\xC5\a\x61\x2\x2\xB4\xB5\a?\x2\x2\xB5\xC5\a?\x2\x2\xB6\xB7\a`\x2\x2\xB7"+
		"\xC5\a`\x2\x2\xB8\xB9\a\x80\x2\x2\xB9\xC5\a\x80\x2\x2\xBA\xBB\a}\x2\x2"+
		"\xBB\xBC\a}\x2\x2\xBC\xC5\a}\x2\x2\xBD\xBE\a\x31\x2\x2\xBE\xC5\a\'\x2"+
		"\x2\xBF\xC0\a\x7F\x2\x2\xC0\xC1\a\x7F\x2\x2\xC1\xC5\a\x7F\x2\x2\xC2\xC3"+
		"\a\'\x2\x2\xC3\xC5\a\x31\x2\x2\xC4\xAE\x3\x2\x2\x2\xC4\xB0\x3\x2\x2\x2"+
		"\xC4\xB2\x3\x2\x2\x2\xC4\xB4\x3\x2\x2\x2\xC4\xB6\x3\x2\x2\x2\xC4\xB8\x3"+
		"\x2\x2\x2\xC4\xBA\x3\x2\x2\x2\xC4\xBD\x3\x2\x2\x2\xC4\xBF\x3\x2\x2\x2"+
		"\xC4\xC2\x3\x2\x2\x2\xC5\x17\x3\x2\x2\x2\xC6\xC7\t\x2\x2\x2\xC7\x19\x3"+
		"\x2\x2\x2\xC8\xCC\t\x3\x2\x2\xC9\xCA\a\xF\x2\x2\xCA\xCC\a\f\x2\x2\xCB"+
		"\xC8\x3\x2\x2\x2\xCB\xC9\x3\x2\x2\x2\xCC\x1B\x3\x2\x2\x2\xCD\xCE\x5\x36"+
		"\x18\x2\xCE\xCF\x3\x2\x2\x2\xCF\xD0\b\v\x6\x2\xD0\x1D\x3\x2\x2\x2\xD1"+
		"\xD2\x5\x38\x19\x2\xD2\xD3\x3\x2\x2\x2\xD3\xD4\b\f\a\x2\xD4\x1F\x3\x2"+
		"\x2\x2\xD5\xD6\a\"\x2\x2\xD6!\x3\x2\x2\x2\xD7\xD8\n\x4\x2\x2\xD8#\x3\x2"+
		"\x2\x2\xD9\xDA\x5\x1C\v\x2\xDA\xDB\x5\x46 \x2\xDB\xDC\x5H!\x2\xDC\xE2"+
		"\x3\x2\x2\x2\xDD\xDE\x5\x1E\f\x2\xDE\xDF\x5J\"\x2\xDF\xE0\x5L#\x2\xE0"+
		"\xE2\x3\x2\x2\x2\xE1\xD9\x3\x2\x2\x2\xE1\xDD\x3\x2\x2\x2\xE2%\x3\x2\x2"+
		"\x2\xE3\xE4\t\x5\x2\x2\xE4\'\x3\x2\x2\x2\xE5\xE6\t\x6\x2\x2\xE6)\x3\x2"+
		"\x2\x2\xE7\xE8\a<\x2\x2\xE8+\x3\x2\x2\x2\xE9\xEA\a#\x2\x2\xEA-\x3\x2\x2"+
		"\x2\xEB\xEC\a\x30\x2\x2\xEC/\x3\x2\x2\x2\xED\xEE\a.\x2\x2\xEE\x31\x3\x2"+
		"\x2\x2\xEF\xF0\a=\x2\x2\xF0\x33\x3\x2\x2\x2\xF1\xF2\a\x61\x2\x2\xF2\x35"+
		"\x3\x2\x2\x2\xF3\xF4\a$\x2\x2\xF4\x37\x3\x2\x2\x2\xF5\xF6\a)\x2\x2\xF6"+
		"\x39\x3\x2\x2\x2\xF7\xF8\a&\x2\x2\xF8;\x3\x2\x2\x2\xF9\xFB\x5 \r\x2\xFA"+
		"\xF9\x3\x2\x2\x2\xFB\xFE\x3\x2\x2\x2\xFC\xFA\x3\x2\x2\x2\xFC\xFD\x3\x2"+
		"\x2\x2\xFD\x10F\x3\x2\x2\x2\xFE\xFC\x3\x2\x2\x2\xFF\x106\x5\"\xE\x2\x100"+
		"\x106\x5\n\x2\x2\x101\x102\a\x31\x2\x2\x102\x106\a\'\x2\x2\x103\x104\a"+
		"\'\x2\x2\x104\x106\a\x31\x2\x2\x105\xFF\x3\x2\x2\x2\x105\x100\x3\x2\x2"+
		"\x2\x105\x101\x3\x2\x2\x2\x105\x103\x3\x2\x2\x2\x106\x107\x3\x2\x2\x2"+
		"\x107\x105\x3\x2\x2\x2\x107\x108\x3\x2\x2\x2\x108\x10C\x3\x2\x2\x2\x109"+
		"\x10B\x5 \r\x2\x10A\x109\x3\x2\x2\x2\x10B\x10E\x3\x2\x2\x2\x10C\x10A\x3"+
		"\x2\x2\x2\x10C\x10D\x3\x2\x2\x2\x10D\x110\x3\x2\x2\x2\x10E\x10C\x3\x2"+
		"\x2\x2\x10F\x105\x3\x2\x2\x2\x110\x111\x3\x2\x2\x2\x111\x10F\x3\x2\x2"+
		"\x2\x111\x112\x3\x2\x2\x2\x112=\x3\x2\x2\x2\x113\x129\x5@\x1D\x2\x114"+
		"\x128\t\a\x2\x2\x115\x117\x5 \r\x2\x116\x115\x3\x2\x2\x2\x117\x11A\x3"+
		"\x2\x2\x2\x118\x116\x3\x2\x2\x2\x118\x119\x3\x2\x2\x2\x119\x11D\x3\x2"+
		"\x2\x2\x11A\x118\x3\x2\x2\x2\x11B\x11E\x5\"\xE\x2\x11C\x11E\x5\n\x2\x2"+
		"\x11D\x11B\x3\x2\x2\x2\x11D\x11C\x3\x2\x2\x2\x11E\x11F\x3\x2\x2\x2\x11F"+
		"\x11D\x3\x2\x2\x2\x11F\x120\x3\x2\x2\x2\x120\x124\x3\x2\x2\x2\x121\x123"+
		"\x5 \r\x2\x122\x121\x3\x2\x2\x2\x123\x126\x3\x2\x2\x2\x124\x122\x3\x2"+
		"\x2\x2\x124\x125\x3\x2\x2\x2\x125\x128\x3\x2\x2\x2\x126\x124\x3\x2\x2"+
		"\x2\x127\x114\x3\x2\x2\x2\x127\x118\x3\x2\x2\x2\x128\x12B\x3\x2\x2\x2"+
		"\x129\x127\x3\x2\x2\x2\x129\x12A\x3\x2\x2\x2\x12A\x12C\x3\x2\x2\x2\x12B"+
		"\x129\x3\x2\x2\x2\x12C\x12D\x5\x42\x1E\x2\x12D?\x3\x2\x2\x2\x12E\x12F"+
		"\a]\x2\x2\x12F\x41\x3\x2\x2\x2\x130\x131\a_\x2\x2\x131\x43\x3\x2\x2\x2"+
		"\x132\x134\x5 \r\x2\x133\x132\x3\x2\x2\x2\x134\x137\x3\x2\x2\x2\x135\x133"+
		"\x3\x2\x2\x2\x135\x136\x3\x2\x2\x2\x136\x138\x3\x2\x2\x2\x137\x135\x3"+
		"\x2\x2\x2\x138\x139\x5\x1A\n\x2\x139\x13A\x3\x2\x2\x2\x13A\x13B\b\x1F"+
		"\b\x2\x13B\x45\x3\x2\x2\x2\x13C\x13E\v\x2\x2\x2\x13D\x13C\x3\x2\x2\x2"+
		"\x13E\x141\x3\x2\x2\x2\x13F\x140\x3\x2\x2\x2\x13F\x13D\x3\x2\x2\x2\x140"+
		"G\x3\x2\x2\x2\x141\x13F\x3\x2\x2\x2\x142\x143\x5\x36\x18\x2\x143\x144"+
		"\x3\x2\x2\x2\x144\x145\b!\b\x2\x145I\x3\x2\x2\x2\x146\x148\v\x2\x2\x2"+
		"\x147\x146\x3\x2\x2\x2\x148\x14B\x3\x2\x2\x2\x149\x14A\x3\x2\x2\x2\x149"+
		"\x147\x3\x2\x2\x2\x14AK\x3\x2\x2\x2\x14B\x149\x3\x2\x2\x2\x14C\x14D\x5"+
		"\x38\x19\x2\x14D\x14E\x3\x2\x2\x2\x14E\x14F\b#\b\x2\x14FM\x3\x2\x2\x2"+
		"\x150\x151\at\x2\x2\x151\x152\a\x63\x2\x2\x152\x153\ap\x2\x2\x153\x154"+
		"\a\x66\x2\x2\x154\x155\aq\x2\x2\x155\x180\ao\x2\x2\x156\x157\ag\x2\x2"+
		"\x157\x158\ak\x2\x2\x158\x159\av\x2\x2\x159\x15A\aj\x2\x2\x15A\x15B\a"+
		"g\x2\x2\x15B\x180\at\x2\x2\x15C\x15D\ax\x2\x2\x15D\x15E\ak\x2\x2\x15E"+
		"\x15F\au\x2\x2\x15F\x160\ak\x2\x2\x160\x161\av\x2\x2\x161\x162\ag\x2\x2"+
		"\x162\x180\a\x66\x2\x2\x163\x164\ax\x2\x2\x164\x165\ak\x2\x2\x165\x166"+
		"\au\x2\x2\x166\x167\ak\x2\x2\x167\x168\av\x2\x2\x168\x169\ag\x2\x2\x169"+
		"\x16A\a\x66\x2\x2\x16A\x16B\aV\x2\x2\x16B\x16C\a\x63\x2\x2\x16C\x180\a"+
		"i\x2\x2\x16D\x16E\av\x2\x2\x16E\x16F\aw\x2\x2\x16F\x170\at\x2\x2\x170"+
		"\x171\ap\x2\x2\x171\x180\au\x2\x2\x172\x173\a\x65\x2\x2\x173\x174\aq\x2"+
		"\x2\x174\x175\ap\x2\x2\x175\x176\ah\x2\x2\x176\x177\ak\x2\x2\x177\x178"+
		"\at\x2\x2\x178\x180\ao\x2\x2\x179\x17A\ar\x2\x2\x17A\x17B\at\x2\x2\x17B"+
		"\x17C\aq\x2\x2\x17C\x17D\ao\x2\x2\x17D\x17E\ar\x2\x2\x17E\x180\av\x2\x2"+
		"\x17F\x150\x3\x2\x2\x2\x17F\x156\x3\x2\x2\x2\x17F\x15C\x3\x2\x2\x2\x17F"+
		"\x163\x3\x2\x2\x2\x17F\x16D\x3\x2\x2\x2\x17F\x172\x3\x2\x2\x2\x17F\x179"+
		"\x3\x2\x2\x2\x180O\x3\x2\x2\x2\x181\x182\a*\x2\x2\x182\x183\x3\x2\x2\x2"+
		"\x183\x184\b%\t\x2\x184Q\x3\x2\x2\x2\x185\x186\a+\x2\x2\x186\x187\x3\x2"+
		"\x2\x2\x187\x188\b&\b\x2\x188S\x3\x2\x2\x2\x189\x18A\ak\x2\x2\x18A\x18B"+
		"\ah\x2\x2\x18B\x18C\x3\x2\x2\x2\x18C\x18D\b\'\t\x2\x18DU\x3\x2\x2\x2\x18E"+
		"\x18F\ag\x2\x2\x18F\x190\an\x2\x2\x190\x191\au\x2\x2\x191\x192\ag\x2\x2"+
		"\x192\x193\a\"\x2\x2\x193\x194\ak\x2\x2\x194\x195\ah\x2\x2\x195\x196\x3"+
		"\x2\x2\x2\x196\x197\b(\t\x2\x197W\x3\x2\x2\x2\x198\x199\ag\x2\x2\x199"+
		"\x19A\an\x2\x2\x19A\x19B\au\x2\x2\x19B\x19C\ag\x2\x2\x19C\x1A1\x3\x2\x2"+
		"\x2\x19D\x1A0\x5 \r\x2\x19E\x1A0\x5\x1A\n\x2\x19F\x19D\x3\x2\x2\x2\x19F"+
		"\x19E\x3\x2\x2\x2\x1A0\x1A3\x3\x2\x2\x2\x1A1\x19F\x3\x2\x2\x2\x1A1\x1A2"+
		"\x3\x2\x2\x2\x1A2Y\x3\x2\x2\x2\x1A3\x1A1\x3\x2\x2\x2\x1A4\x1A5\ag\x2\x2"+
		"\x1A5\x1A6\ap\x2\x2\x1A6\x1A7\a\x66\x2\x2\x1A7\x1A8\ak\x2\x2\x1A8\x1A9"+
		"\ah\x2\x2\x1A9\x1AE\x3\x2\x2\x2\x1AA\x1AD\x5 \r\x2\x1AB\x1AD\x5\x1A\n"+
		"\x2\x1AC\x1AA\x3\x2\x2\x2\x1AC\x1AB\x3\x2\x2\x2\x1AD\x1B0\x3\x2\x2\x2"+
		"\x1AE\x1AC\x3\x2\x2\x2\x1AE\x1AF\x3\x2\x2\x2\x1AF[\x3\x2\x2\x2\x1B0\x1AE"+
		"\x3\x2\x2\x2\x1B1\x1B2\ap\x2\x2\x1B2\x1B3\aq\x2\x2\x1B3\x1B4\a\x64\x2"+
		"\x2\x1B4\x1B5\at\x2\x2\x1B5\x1BA\x3\x2\x2\x2\x1B6\x1B9\x5 \r\x2\x1B7\x1B9"+
		"\x5\x1A\n\x2\x1B8\x1B6\x3\x2\x2\x2\x1B8\x1B7\x3\x2\x2\x2\x1B9\x1BC\x3"+
		"\x2\x2\x2\x1BA\x1B8\x3\x2\x2\x2\x1BA\x1BB\x3\x2\x2\x2\x1BB]\x3\x2\x2\x2"+
		"\x1BC\x1BA\x3\x2\x2\x2\x1BD\x1BE\ag\x2\x2\x1BE\x1BF\ap\x2\x2\x1BF\x1C0"+
		"\a\x66\x2\x2\x1C0\x1C1\ap\x2\x2\x1C1\x1C2\aq\x2\x2\x1C2\x1C3\a\x64\x2"+
		"\x2\x1C3\x1C4\at\x2\x2\x1C4\x1C9\x3\x2\x2\x2\x1C5\x1C8\x5 \r\x2\x1C6\x1C8"+
		"\x5\x1A\n\x2\x1C7\x1C5\x3\x2\x2\x2\x1C7\x1C6\x3\x2\x2\x2\x1C8\x1CB\x3"+
		"\x2\x2\x2\x1C9\x1C7\x3\x2\x2\x2\x1C9\x1CA\x3\x2\x2\x2\x1CA_\x3\x2\x2\x2"+
		"\x1CB\x1C9\x3\x2\x2\x2\x1CC\x1CD\au\x2\x2\x1CD\x1CE\ak\x2\x2\x1CE\x1CF"+
		"\an\x2\x2\x1CF\x1D0\ag\x2\x2\x1D0\x1D1\ap\x2\x2\x1D1\x1D2\av\x2\x2\x1D2"+
		"\x1D3\an\x2\x2\x1D3\x1D4\a{\x2\x2\x1D4\x1D9\x3\x2\x2\x2\x1D5\x1D8\x5 "+
		"\r\x2\x1D6\x1D8\x5\x1A\n\x2\x1D7\x1D5\x3\x2\x2\x2\x1D7\x1D6\x3\x2\x2\x2"+
		"\x1D8\x1DB\x3\x2\x2\x2\x1D9\x1D7\x3\x2\x2\x2\x1D9\x1DA\x3\x2\x2\x2\x1DA"+
		"\x61\x3\x2\x2\x2\x1DB\x1D9\x3\x2\x2\x2\x1DC\x1DD\ag\x2\x2\x1DD\x1DE\a"+
		"p\x2\x2\x1DE\x1DF\a\x66\x2\x2\x1DF\x1E0\au\x2\x2\x1E0\x1E1\ak\x2\x2\x1E1"+
		"\x1E2\an\x2\x2\x1E2\x1E3\ag\x2\x2\x1E3\x1E4\ap\x2\x2\x1E4\x1E5\av\x2\x2"+
		"\x1E5\x1E6\an\x2\x2\x1E6\x1E7\a{\x2\x2\x1E7\x1EC\x3\x2\x2\x2\x1E8\x1EB"+
		"\x5 \r\x2\x1E9\x1EB\x5\x1A\n\x2\x1EA\x1E8\x3\x2\x2\x2\x1EA\x1E9\x3\x2"+
		"\x2\x2\x1EB\x1EE\x3\x2\x2\x2\x1EC\x1EA\x3\x2\x2\x2\x1EC\x1ED\x3\x2\x2"+
		"\x2\x1ED\x63\x3\x2\x2\x2\x1EE\x1EC\x3\x2\x2\x2\x1EF\x1F0\a\x63\x2\x2\x1F0"+
		"\x1F1\a\x65\x2\x2\x1F1\x1F2\av\x2\x2\x1F2\x1F3\ak\x2\x2\x1F3\x1F4\aq\x2"+
		"\x2\x1F4\x1F5\ap\x2\x2\x1F5\x1F6\au\x2\x2\x1F6\x1FB\x3\x2\x2\x2\x1F7\x1FA"+
		"\x5 \r\x2\x1F8\x1FA\x5\x1A\n\x2\x1F9\x1F7\x3\x2\x2\x2\x1F9\x1F8\x3\x2"+
		"\x2\x2\x1FA\x1FD\x3\x2\x2\x2\x1FB\x1F9\x3\x2\x2\x2\x1FB\x1FC\x3\x2\x2"+
		"\x2\x1FC\x65\x3\x2\x2\x2\x1FD\x1FB\x3\x2\x2\x2\x1FE\x1FF\a\x65\x2\x2\x1FF"+
		"\x200\aj\x2\x2\x200\x201\aq\x2\x2\x201\x202\ak\x2\x2\x202\x203\a\x65\x2"+
		"\x2\x203\x204\ag\x2\x2\x204\x209\x3\x2\x2\x2\x205\x208\x5 \r\x2\x206\x208"+
		"\x5\x1A\n\x2\x207\x205\x3\x2\x2\x2\x207\x206\x3\x2\x2\x2\x208\x20B\x3"+
		"\x2\x2\x2\x209\x207\x3\x2\x2\x2\x209\x20A\x3\x2\x2\x2\x20Ag\x3\x2\x2\x2"+
		"\x20B\x209\x3\x2\x2\x2\x20C\x20D\a\x66\x2\x2\x20D\x20E\ak\x2\x2\x20E\x20F"+
		"\au\x2\x2\x20F\x210\ar\x2\x2\x210\x211\an\x2\x2\x211\x212\a\x63\x2\x2"+
		"\x212\x213\a{\x2\x2\x213\x214\x3\x2\x2\x2\x214\x215\b\x31\t\x2\x215i\x3"+
		"\x2\x2\x2\x216\x217\au\x2\x2\x217\x218\ag\x2\x2\x218\x219\av\x2\x2\x219"+
		"\x21A\x3\x2\x2\x2\x21A\x21B\b\x32\t\x2\x21Bk\x3\x2\x2\x2\x21C\x21D\ar"+
		"\x2\x2\x21D\x21E\at\x2\x2\x21E\x21F\ak\x2\x2\x21F\x220\ap\x2\x2\x220\x221"+
		"\av\x2\x2\x221\x222\x3\x2\x2\x2\x222\x223\b\x33\t\x2\x223m\x3\x2\x2\x2"+
		"\x224\x225\a>\x2\x2\x225\x226\a>\x2\x2\x226o\x3\x2\x2\x2\x227\x228\a@"+
		"\x2\x2\x228\x229\a@\x2\x2\x229\x22A\x3\x2\x2\x2\x22A\x22B\b\x35\b\x2\x22B"+
		"q\x3\x2\x2\x2\x22C\x22D\x5t\x37\x2\x22D\x22E\x3\x2\x2\x2\x22E\x22F\b\x36"+
		"\b\x2\x22F\x230\b\x36\b\x2\x230s\x3\x2\x2\x2\x231\x232\x5$\xF\x2\x232"+
		"\x233\x5t\x37\x2\x233\x239\x3\x2\x2\x2\x234\x235\n\b\x2\x2\x235\x239\x5"+
		"t\x37\x2\x236\x237\v\x2\x2\x2\x237\x239\x5v\x38\x2\x238\x231\x3\x2\x2"+
		"\x2\x238\x234\x3\x2\x2\x2\x238\x236\x3\x2\x2\x2\x239u\x3\x2\x2\x2\x23A"+
		"\x23B\n\b\x2\x2\x23B\x23E\x5t\x37\x2\x23C\x23E\v\x2\x2\x2\x23D\x23A\x3"+
		"\x2\x2\x2\x23D\x23C\x3\x2\x2\x2\x23Ew\x3\x2\x2\x2\x23F\x240\a@\x2\x2\x240"+
		"\x241\a@\x2\x2\x241\x242\x3\x2\x2\x2\x242\x243\b\x39\b\x2\x243\x244\b"+
		"\x39\b\x2\x244y\x3\x2\x2\x2\x245\x246\ar\x2\x2\x246\x247\at\x2\x2\x247"+
		"\x248\ag\x2\x2\x248\x249\ax\x2\x2\x249\x24A\ak\x2\x2\x24A\x24B\aq\x2\x2"+
		"\x24B\x24C\aw\x2\x2\x24C\x24D\au\x2\x2\x24D\x24E\a*\x2\x2\x24E\x260\a"+
		"+\x2\x2\x24F\x250\au\x2\x2\x250\x251\av\x2\x2\x251\x252\a\x63\x2\x2\x252"+
		"\x253\at\x2\x2\x253\x254\av\x2\x2\x254\x255\a*\x2\x2\x255\x260\a+\x2\x2"+
		"\x256\x257\ar\x2\x2\x257\x258\a\x63\x2\x2\x258\x259\au\x2\x2\x259\x25A"+
		"\au\x2\x2\x25A\x25B\a\x63\x2\x2\x25B\x25C\ai\x2\x2\x25C\x25D\ag\x2\x2"+
		"\x25D\x25E\a*\x2\x2\x25E\x260\a+\x2\x2\x25F\x245\x3\x2\x2\x2\x25F\x24F"+
		"\x3\x2\x2\x2\x25F\x256\x3\x2\x2\x2\x260{\x3\x2\x2\x2\x261\x262\a~\x2\x2"+
		"\x262}\x3\x2\x2\x2\x263\x264\a_\x2\x2\x264\x7F\x3\x2\x2\x2\x265\x266\a"+
		"]\x2\x2\x266\x267\x3\x2\x2\x2\x267\x268\b=\t\x2\x268\x81\x3\x2\x2\x2\x269"+
		"\x26C\x5\"\xE\x2\x26A\x26C\x5 \r\x2\x26B\x269\x3\x2\x2\x2\x26B\x26A\x3"+
		"\x2\x2\x2\x26C\x26D\x3\x2\x2\x2\x26D\x26B\x3\x2\x2\x2\x26D\x26E\x3\x2"+
		"\x2\x2\x26E\x83\x3\x2\x2\x2\x26F\x270\a_\x2\x2\x270\x271\a_\x2\x2\x271"+
		"\x272\x3\x2\x2\x2\x272\x273\b?\b\x2\x273\x85\x3\x2\x2\x2\x36\x2\x3\x4"+
		"\x5\x6\a\b\t\x89\x90\xA4\xA9\xAB\xC4\xCB\xE1\xFC\x105\x107\x10C\x111\x118"+
		"\x11D\x11F\x124\x127\x129\x135\x13F\x149\x17F\x19F\x1A1\x1AC\x1AE\x1B8"+
		"\x1BA\x1C7\x1C9\x1D7\x1D9\x1EA\x1EC\x1F9\x1FB\x207\x209\x238\x23D\x25F"+
		"\x26B\x26D\n\a\x3\x2\a\a\x2\a\t\x2\a\x6\x2\a\x4\x2\a\x5\x2\x6\x2\x2\a"+
		"\b\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Twee2Z.Analyzer
