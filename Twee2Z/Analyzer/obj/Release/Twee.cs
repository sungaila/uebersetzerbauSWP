//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.4.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\David\Desktop\Twee\uebersetzerbauSWP\Twee2Z\Analyzer\Twee.g4 by ANTLR 4.4.1-SNAPSHOT

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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.4.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class Twee : Parser {
	public const int
		PRINT=36, ADD=43, FORMAT=7, ENDNOBR=29, FUNC_START=5, LINK_START=4, PIPE=53, 
		FUNC_BRACKET_CLOSE=23, LINK_END=57, ELSE_IF=25, STRING_BODY=19, ELSE=26, 
		IF=24, SUB=44, WORD=12, VAR_NAME=6, MUL=41, ENDSILENTLY=31, SQ_BRACKET_OPEN=55, 
		NEW_LINE=9, NOT=48, PASS=2, MACRO_START=3, MACRO_BRACKET_OPEN=37, EXP_END=49, 
		EXCLUDE=8, STRING_END=20, SET=35, PMODE_END=18, FUNC_LINK=52, INT=1, SPACE=11, 
		CHOICE=33, DISPLAY=34, PMODEWORD=14, ACTIONS=32, EQ_SIGN=47, TAG_BEGIN=16, 
		MACRO_END=38, EXP_END_M=51, EXP_END_L=50, MOD=46, WORDS=56, ENDIF=27, 
		SILENTLY=30, STRING_START=10, DIV=42, FUNC_NAME=21, NOBR=28, LOG_OP=45, 
		SQ_BRACKET_CLOSE=54, STRING=13, TAG=15, FUNC_BRACKET_OPEN=22, TAG_END=17, 
		EXPRESSION=39, FUNC_PARAM=40;
	public const int
		RULE_start = 0, RULE_ignoreFirst = 1, RULE_passage = 2, RULE_passageContent = 3, 
		RULE_link = 4, RULE_macro = 5, RULE_function = 6, RULE_variable = 7, RULE_zeichenkette = 8, 
		RULE_text = 9;
	public static readonly string[] ruleNames = {
		"start", "ignoreFirst", "passage", "passageContent", "link", "macro", 
		"function", "variable", "zeichenkette", "text"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'[['", null, null, null, null, null, null, "' '", 
		null, null, null, null, null, null, null, null, null, null, "'('", null, 
		"'if'", "'else if'", null, null, null, null, null, null, null, null, null, 
		null, null, null, "'>>'", null, null, "'*'", "'/'", "'+'", "'-'", null, 
		"'%'", "'='", "'not'", null, null, null, null, "'|'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INT", "PASS", "MACRO_START", "LINK_START", "FUNC_START", "VAR_NAME", 
		"FORMAT", "EXCLUDE", "NEW_LINE", "STRING_START", "SPACE", "WORD", "STRING", 
		"PMODEWORD", "TAG", "TAG_BEGIN", "TAG_END", "PMODE_END", "STRING_BODY", 
		"STRING_END", "FUNC_NAME", "FUNC_BRACKET_OPEN", "FUNC_BRACKET_CLOSE", 
		"IF", "ELSE_IF", "ELSE", "ENDIF", "NOBR", "ENDNOBR", "SILENTLY", "ENDSILENTLY", 
		"ACTIONS", "CHOICE", "DISPLAY", "SET", "PRINT", "MACRO_BRACKET_OPEN", 
		"MACRO_END", "EXPRESSION", "FUNC_PARAM", "MUL", "DIV", "ADD", "SUB", "LOG_OP", 
		"MOD", "EQ_SIGN", "NOT", "EXP_END", "EXP_END_L", "EXP_END_M", "FUNC_LINK", 
		"PIPE", "SQ_BRACKET_CLOSE", "SQ_BRACKET_OPEN", "WORDS", "LINK_END"
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

	public override string GrammarFileName { get { return "Twee.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public Twee(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class StartContext : ParserRuleContext {
		public IReadOnlyList<PassageContext> passage() {
			return GetRuleContexts<PassageContext>();
		}
		public PassageContext passage(int i) {
			return GetRuleContext<PassageContext>(i);
		}
		public IgnoreFirstContext ignoreFirst() {
			return GetRuleContext<IgnoreFirstContext>(0);
		}
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitStart(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStart(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_start);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; ignoreFirst();
			State = 24;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==PASS) {
				{
				{
				State = 21; passage();
				}
				}
				State = 26;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IgnoreFirstContext : ParserRuleContext {
		public PassageContext passage() {
			return GetRuleContext<PassageContext>(0);
		}
		public ITerminalNode PASS() { return GetToken(Twee.PASS, 0); }
		public IgnoreFirstContext ignoreFirst() {
			return GetRuleContext<IgnoreFirstContext>(0);
		}
		public IgnoreFirstContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ignoreFirst; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterIgnoreFirst(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitIgnoreFirst(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIgnoreFirst(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IgnoreFirstContext ignoreFirst() {
		IgnoreFirstContext _localctx = new IgnoreFirstContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_ignoreFirst);
		int _la;
		try {
			State = 30;
			switch (_input.La(1)) {
			case PASS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 27; passage();
				}
				break;
			case INT:
			case MACRO_START:
			case LINK_START:
			case FUNC_START:
			case VAR_NAME:
			case FORMAT:
			case EXCLUDE:
			case NEW_LINE:
			case STRING_START:
			case SPACE:
			case WORD:
			case STRING:
			case PMODEWORD:
			case TAG:
			case TAG_BEGIN:
			case TAG_END:
			case PMODE_END:
			case STRING_BODY:
			case STRING_END:
			case FUNC_NAME:
			case FUNC_BRACKET_OPEN:
			case FUNC_BRACKET_CLOSE:
			case IF:
			case ELSE_IF:
			case ELSE:
			case ENDIF:
			case NOBR:
			case ENDNOBR:
			case SILENTLY:
			case ENDSILENTLY:
			case ACTIONS:
			case CHOICE:
			case DISPLAY:
			case SET:
			case PRINT:
			case MACRO_BRACKET_OPEN:
			case MACRO_END:
			case EXPRESSION:
			case FUNC_PARAM:
			case MUL:
			case DIV:
			case ADD:
			case SUB:
			case LOG_OP:
			case MOD:
			case EQ_SIGN:
			case NOT:
			case EXP_END:
			case EXP_END_L:
			case EXP_END_M:
			case FUNC_LINK:
			case PIPE:
			case SQ_BRACKET_CLOSE:
			case SQ_BRACKET_OPEN:
			case WORDS:
			case LINK_END:
				EnterOuterAlt(_localctx, 2);
				{
				State = 28;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==PASS) ) {
				_errHandler.RecoverInline(this);
				}
				Consume();
				State = 29; ignoreFirst();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PassageContext : ParserRuleContext {
		public ITerminalNode PMODE_END(int i) {
			return GetToken(Twee.PMODE_END, i);
		}
		public ITerminalNode TAG() { return GetToken(Twee.TAG, 0); }
		public PassageContentContext passageContent() {
			return GetRuleContext<PassageContentContext>(0);
		}
		public ITerminalNode PASS() { return GetToken(Twee.PASS, 0); }
		public ITerminalNode PMODEWORD() { return GetToken(Twee.PMODEWORD, 0); }
		public IReadOnlyList<ITerminalNode> PMODE_END() { return GetTokens(Twee.PMODE_END); }
		public PassageContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_passage; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterPassage(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitPassage(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPassage(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PassageContext passage() {
		PassageContext _localctx = new PassageContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_passage);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32; Match(PASS);
			State = 33; Match(PMODEWORD);
			State = 35;
			switch ( Interpreter.AdaptivePredict(_input,2,_ctx) ) {
			case 1:
				{
				State = 34; Match(TAG);
				}
				break;
			}
			State = 40;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << INT) | (1L << PASS) | (1L << MACRO_START) | (1L << LINK_START) | (1L << FUNC_START) | (1L << VAR_NAME) | (1L << FORMAT) | (1L << EXCLUDE) | (1L << NEW_LINE) | (1L << STRING_START) | (1L << SPACE) | (1L << WORD) | (1L << STRING) | (1L << PMODEWORD) | (1L << TAG) | (1L << TAG_BEGIN) | (1L << TAG_END) | (1L << STRING_BODY) | (1L << STRING_END) | (1L << FUNC_NAME) | (1L << FUNC_BRACKET_OPEN) | (1L << FUNC_BRACKET_CLOSE) | (1L << IF) | (1L << ELSE_IF) | (1L << ELSE) | (1L << ENDIF) | (1L << NOBR) | (1L << ENDNOBR) | (1L << SILENTLY) | (1L << ENDSILENTLY) | (1L << ACTIONS) | (1L << CHOICE) | (1L << DISPLAY) | (1L << SET) | (1L << PRINT) | (1L << MACRO_BRACKET_OPEN) | (1L << MACRO_END) | (1L << EXPRESSION) | (1L << FUNC_PARAM) | (1L << MUL) | (1L << DIV) | (1L << ADD) | (1L << SUB) | (1L << LOG_OP) | (1L << MOD) | (1L << EQ_SIGN) | (1L << NOT) | (1L << EXP_END) | (1L << EXP_END_L) | (1L << EXP_END_M) | (1L << FUNC_LINK) | (1L << PIPE) | (1L << SQ_BRACKET_CLOSE) | (1L << SQ_BRACKET_OPEN) | (1L << WORDS) | (1L << LINK_END))) != 0)) {
				{
				{
				State = 37;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==PMODE_END) ) {
				_errHandler.RecoverInline(this);
				}
				Consume();
				}
				}
				State = 42;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 43; Match(PMODE_END);
			State = 45;
			_la = _input.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << INT) | (1L << MACRO_START) | (1L << LINK_START) | (1L << FUNC_START) | (1L << VAR_NAME) | (1L << FORMAT) | (1L << EXCLUDE) | (1L << NEW_LINE) | (1L << SPACE) | (1L << WORD) | (1L << STRING))) != 0)) {
				{
				State = 44; passageContent();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PassageContentContext : ParserRuleContext {
		public PassageContentContext passageContent() {
			return GetRuleContext<PassageContentContext>(0);
		}
		public TextContext text() {
			return GetRuleContext<TextContext>(0);
		}
		public LinkContext link() {
			return GetRuleContext<LinkContext>(0);
		}
		public FunctionContext function() {
			return GetRuleContext<FunctionContext>(0);
		}
		public VariableContext variable() {
			return GetRuleContext<VariableContext>(0);
		}
		public MacroContext macro() {
			return GetRuleContext<MacroContext>(0);
		}
		public PassageContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_passageContent; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterPassageContent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitPassageContent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPassageContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PassageContentContext passageContent() {
		PassageContentContext _localctx = new PassageContentContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_passageContent);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52;
			switch (_input.La(1)) {
			case MACRO_START:
				{
				State = 47; macro();
				}
				break;
			case FUNC_START:
				{
				State = 48; function();
				}
				break;
			case INT:
			case FORMAT:
			case EXCLUDE:
			case NEW_LINE:
			case SPACE:
			case WORD:
			case STRING:
				{
				State = 49; text();
				}
				break;
			case VAR_NAME:
				{
				State = 50; variable();
				}
				break;
			case LINK_START:
				{
				State = 51; link();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 55;
			switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
			case 1:
				{
				State = 54; passageContent();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LinkContext : ParserRuleContext {
		public ITerminalNode SQ_BRACKET_OPEN() { return GetToken(Twee.SQ_BRACKET_OPEN, 0); }
		public ITerminalNode EXP_END_L() { return GetToken(Twee.EXP_END_L, 0); }
		public ITerminalNode LINK_START() { return GetToken(Twee.LINK_START, 0); }
		public ITerminalNode SQ_BRACKET_CLOSE() { return GetToken(Twee.SQ_BRACKET_CLOSE, 0); }
		public ITerminalNode FUNC_LINK() { return GetToken(Twee.FUNC_LINK, 0); }
		public IReadOnlyList<ITerminalNode> WORDS() { return GetTokens(Twee.WORDS); }
		public ITerminalNode PIPE() { return GetToken(Twee.PIPE, 0); }
		public ITerminalNode EXPRESSION() { return GetToken(Twee.EXPRESSION, 0); }
		public ITerminalNode LINK_END() { return GetToken(Twee.LINK_END, 0); }
		public ITerminalNode WORDS(int i) {
			return GetToken(Twee.WORDS, i);
		}
		public LinkContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_link; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterLink(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitLink(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLink(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LinkContext link() {
		LinkContext _localctx = new LinkContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_link);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57; Match(LINK_START);
			State = 60;
			switch ( Interpreter.AdaptivePredict(_input,7,_ctx) ) {
			case 1:
				{
				State = 58; Match(WORDS);
				State = 59; Match(PIPE);
				}
				break;
			}
			State = 62;
			_la = _input.La(1);
			if ( !(_la==FUNC_LINK || _la==WORDS) ) {
			_errHandler.RecoverInline(this);
			}
			Consume();
			State = 68;
			switch (_input.La(1)) {
			case SQ_BRACKET_CLOSE:
				{
				{
				State = 63; Match(SQ_BRACKET_CLOSE);
				State = 64; Match(SQ_BRACKET_OPEN);
				State = 65; Match(EXPRESSION);
				State = 66; Match(EXP_END_L);
				}
				}
				break;
			case LINK_END:
				{
				State = 67; Match(LINK_END);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MacroContext : ParserRuleContext {
		public ITerminalNode ELSE() { return GetToken(Twee.ELSE, 0); }
		public ITerminalNode IF() { return GetToken(Twee.IF, 0); }
		public ITerminalNode ELSE_IF() { return GetToken(Twee.ELSE_IF, 0); }
		public TextContext text() {
			return GetRuleContext<TextContext>(0);
		}
		public ITerminalNode DISPLAY() { return GetToken(Twee.DISPLAY, 0); }
		public IReadOnlyList<ITerminalNode> MACRO_START() { return GetTokens(Twee.MACRO_START); }
		public IReadOnlyList<ITerminalNode> MACRO_END() { return GetTokens(Twee.MACRO_END); }
		public ITerminalNode MACRO_END(int i) {
			return GetToken(Twee.MACRO_END, i);
		}
		public ITerminalNode MACRO_START(int i) {
			return GetToken(Twee.MACRO_START, i);
		}
		public IReadOnlyList<ITerminalNode> EXP_END_M() { return GetTokens(Twee.EXP_END_M); }
		public LinkContext link() {
			return GetRuleContext<LinkContext>(0);
		}
		public IReadOnlyList<ITerminalNode> EXPRESSION() { return GetTokens(Twee.EXPRESSION); }
		public ITerminalNode ENDIF() { return GetToken(Twee.ENDIF, 0); }
		public ITerminalNode ENDNOBR() { return GetToken(Twee.ENDNOBR, 0); }
		public ITerminalNode PRINT() { return GetToken(Twee.PRINT, 0); }
		public PassageContentContext passageContent(int i) {
			return GetRuleContext<PassageContentContext>(i);
		}
		public ITerminalNode EXPRESSION(int i) {
			return GetToken(Twee.EXPRESSION, i);
		}
		public ITerminalNode EXP_END_M(int i) {
			return GetToken(Twee.EXP_END_M, i);
		}
		public ITerminalNode CHOICE() { return GetToken(Twee.CHOICE, 0); }
		public IReadOnlyList<PassageContentContext> passageContent() {
			return GetRuleContexts<PassageContentContext>();
		}
		public ITerminalNode ENDSILENTLY() { return GetToken(Twee.ENDSILENTLY, 0); }
		public ITerminalNode SILENTLY() { return GetToken(Twee.SILENTLY, 0); }
		public ITerminalNode ACTIONS() { return GetToken(Twee.ACTIONS, 0); }
		public ITerminalNode SET() { return GetToken(Twee.SET, 0); }
		public ITerminalNode NOBR() { return GetToken(Twee.NOBR, 0); }
		public MacroContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_macro; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterMacro(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitMacro(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMacro(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MacroContext macro() {
		MacroContext _localctx = new MacroContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_macro);
		int _la;
		try {
			State = 122;
			switch ( Interpreter.AdaptivePredict(_input,13,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 70; Match(MACRO_START);
				State = 71;
				_la = _input.La(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << DISPLAY) | (1L << SET) | (1L << PRINT))) != 0)) ) {
				_errHandler.RecoverInline(this);
				}
				Consume();
				State = 72; Match(EXPRESSION);
				State = 73; Match(EXP_END_M);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 74; Match(MACRO_START);
				State = 81;
				switch (_input.La(1)) {
				case ACTIONS:
					{
					State = 75; Match(ACTIONS);
					State = 76; text();
					}
					break;
				case CHOICE:
					{
					State = 77; Match(CHOICE);
					State = 79;
					_la = _input.La(1);
					if (_la==LINK_START) {
						{
						State = 78; link();
						}
					}

					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 83; Match(MACRO_END);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 84; Match(MACRO_START);
				State = 85; Match(IF);
				State = 86; Match(EXPRESSION);
				State = 87; Match(EXP_END_M);
				State = 88; passageContent();
				State = 94;
				switch ( Interpreter.AdaptivePredict(_input,11,_ctx) ) {
				case 1:
					{
					State = 89; Match(MACRO_START);
					State = 90; Match(ELSE_IF);
					State = 91; Match(EXPRESSION);
					State = 92; Match(EXP_END_M);
					State = 93; passageContent();
					}
					break;
				}
				State = 100;
				switch ( Interpreter.AdaptivePredict(_input,12,_ctx) ) {
				case 1:
					{
					State = 96; Match(MACRO_START);
					State = 97; Match(ELSE);
					State = 98; Match(MACRO_END);
					State = 99; passageContent();
					}
					break;
				}
				State = 102; Match(MACRO_START);
				State = 103; Match(ENDIF);
				State = 104; Match(MACRO_END);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 106; Match(MACRO_START);
				State = 107; Match(NOBR);
				State = 108; Match(MACRO_END);
				State = 109; passageContent();
				State = 110; Match(MACRO_START);
				State = 111; Match(ENDNOBR);
				State = 112; Match(MACRO_END);
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 114; Match(MACRO_START);
				State = 115; Match(SILENTLY);
				State = 116; Match(MACRO_END);
				State = 117; passageContent();
				State = 118; Match(MACRO_START);
				State = 119; Match(ENDSILENTLY);
				State = 120; Match(MACRO_END);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionContext : ParserRuleContext {
		public ITerminalNode FUNC_START() { return GetToken(Twee.FUNC_START, 0); }
		public ITerminalNode FUNC_BRACKET_OPEN() { return GetToken(Twee.FUNC_BRACKET_OPEN, 0); }
		public ITerminalNode FUNC_PARAM(int i) {
			return GetToken(Twee.FUNC_PARAM, i);
		}
		public ITerminalNode EXP_END() { return GetToken(Twee.EXP_END, 0); }
		public ITerminalNode EXPRESSION() { return GetToken(Twee.EXPRESSION, 0); }
		public IReadOnlyList<ITerminalNode> FUNC_PARAM() { return GetTokens(Twee.FUNC_PARAM); }
		public FunctionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterFunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitFunction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunction(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionContext function() {
		FunctionContext _localctx = new FunctionContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_function);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 124; Match(FUNC_START);
			State = 125; Match(FUNC_BRACKET_OPEN);
			State = 133;
			switch ( Interpreter.AdaptivePredict(_input,15,_ctx) ) {
			case 1:
				{
				State = 126; Match(EXPRESSION);
				}
				break;

			case 2:
				{
				State = 127; Match(EXPRESSION);
				State = 129;
				_errHandler.Sync(this);
				_la = _input.La(1);
				do {
					{
					{
					State = 128; Match(FUNC_PARAM);
					}
					}
					State = 131;
					_errHandler.Sync(this);
					_la = _input.La(1);
				} while ( _la==FUNC_PARAM );
				}
				break;
			}
			State = 135; Match(EXP_END);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableContext : ParserRuleContext {
		public ITerminalNode VAR_NAME() { return GetToken(Twee.VAR_NAME, 0); }
		public VariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterVariable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitVariable(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VariableContext variable() {
		VariableContext _localctx = new VariableContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_variable);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 137; Match(VAR_NAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ZeichenketteContext : ParserRuleContext {
		public IReadOnlyList<ITerminalNode> WORD() { return GetTokens(Twee.WORD); }
		public ITerminalNode WORD(int i) {
			return GetToken(Twee.WORD, i);
		}
		public ZeichenketteContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_zeichenkette; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterZeichenkette(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitZeichenkette(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitZeichenkette(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ZeichenketteContext zeichenkette() {
		ZeichenketteContext _localctx = new ZeichenketteContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_zeichenkette);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 140;
			_errHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 139; Match(WORD);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 142;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,16,_ctx);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TextContext : ParserRuleContext {
		public ITerminalNode SPACE(int i) {
			return GetToken(Twee.SPACE, i);
		}
		public ITerminalNode FORMAT() { return GetToken(Twee.FORMAT, 0); }
		public TextContext text() {
			return GetRuleContext<TextContext>(0);
		}
		public ITerminalNode EXCLUDE() { return GetToken(Twee.EXCLUDE, 0); }
		public ITerminalNode STRING() { return GetToken(Twee.STRING, 0); }
		public IReadOnlyList<ITerminalNode> SPACE() { return GetTokens(Twee.SPACE); }
		public ITerminalNode INT() { return GetToken(Twee.INT, 0); }
		public ZeichenketteContext zeichenkette() {
			return GetRuleContext<ZeichenketteContext>(0);
		}
		public ITerminalNode NEW_LINE() { return GetToken(Twee.NEW_LINE, 0); }
		public TextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_text; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.EnterText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITweeListener typedListener = listener as ITweeListener;
			if (typedListener != null) typedListener.ExitText(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITweeVisitor<TResult> typedVisitor = visitor as ITweeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitText(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TextContext text() {
		TextContext _localctx = new TextContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_text);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 155;
			switch (_input.La(1)) {
			case WORD:
				{
				State = 144; zeichenkette();
				}
				break;
			case SPACE:
				{
				State = 146;
				_errHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 145; Match(SPACE);
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 148;
					_errHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(_input,17,_ctx);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber );
				}
				break;
			case NEW_LINE:
				{
				State = 150; Match(NEW_LINE);
				}
				break;
			case INT:
				{
				State = 151; Match(INT);
				}
				break;
			case FORMAT:
				{
				State = 152; Match(FORMAT);
				}
				break;
			case EXCLUDE:
				{
				State = 153; Match(EXCLUDE);
				}
				break;
			case STRING:
				{
				State = 154; Match(STRING);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 158;
			switch ( Interpreter.AdaptivePredict(_input,19,_ctx) ) {
			case 1:
				{
				State = 157; text();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3;\xA3\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x3\x2\x3\x2\a\x2\x19\n\x2\f\x2\xE\x2\x1C\v\x2\x3"+
		"\x3\x3\x3\x3\x3\x5\x3!\n\x3\x3\x4\x3\x4\x3\x4\x5\x4&\n\x4\x3\x4\a\x4)"+
		"\n\x4\f\x4\xE\x4,\v\x4\x3\x4\x3\x4\x5\x4\x30\n\x4\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x5\x5\x37\n\x5\x3\x5\x5\x5:\n\x5\x3\x6\x3\x6\x3\x6\x5\x6?\n"+
		"\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6G\n\x6\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5\aR\n\a\x5\aT\n\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5\a\x61\n\a\x3\a\x3\a\x3\a\x3\a\x5\a"+
		"g\n\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5\a}\n\a\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x6\b\x84\n\b\r\b\xE\b\x85\x5\b\x88\n\b\x3\b\x3\b\x3\t\x3\t\x3\n\x6\n"+
		"\x8F\n\n\r\n\xE\n\x90\x3\v\x3\v\x6\v\x95\n\v\r\v\xE\v\x96\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x5\v\x9E\n\v\x3\v\x5\v\xA1\n\v\x3\v\x2\x2\x2\f\x2\x2\x4\x2"+
		"\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x2\x6\x3\x2\x4\x4\x3"+
		"\x2\x14\x14\x4\x2\x36\x36::\x3\x2$&\xB8\x2\x16\x3\x2\x2\x2\x4 \x3\x2\x2"+
		"\x2\x6\"\x3\x2\x2\x2\b\x36\x3\x2\x2\x2\n;\x3\x2\x2\x2\f|\x3\x2\x2\x2\xE"+
		"~\x3\x2\x2\x2\x10\x8B\x3\x2\x2\x2\x12\x8E\x3\x2\x2\x2\x14\x9D\x3\x2\x2"+
		"\x2\x16\x1A\x5\x4\x3\x2\x17\x19\x5\x6\x4\x2\x18\x17\x3\x2\x2\x2\x19\x1C"+
		"\x3\x2\x2\x2\x1A\x18\x3\x2\x2\x2\x1A\x1B\x3\x2\x2\x2\x1B\x3\x3\x2\x2\x2"+
		"\x1C\x1A\x3\x2\x2\x2\x1D!\x5\x6\x4\x2\x1E\x1F\n\x2\x2\x2\x1F!\x5\x4\x3"+
		"\x2 \x1D\x3\x2\x2\x2 \x1E\x3\x2\x2\x2!\x5\x3\x2\x2\x2\"#\a\x4\x2\x2#%"+
		"\a\x10\x2\x2$&\a\x11\x2\x2%$\x3\x2\x2\x2%&\x3\x2\x2\x2&*\x3\x2\x2\x2\'"+
		")\n\x3\x2\x2(\'\x3\x2\x2\x2),\x3\x2\x2\x2*(\x3\x2\x2\x2*+\x3\x2\x2\x2"+
		"+-\x3\x2\x2\x2,*\x3\x2\x2\x2-/\a\x14\x2\x2.\x30\x5\b\x5\x2/.\x3\x2\x2"+
		"\x2/\x30\x3\x2\x2\x2\x30\a\x3\x2\x2\x2\x31\x37\x5\f\a\x2\x32\x37\x5\xE"+
		"\b\x2\x33\x37\x5\x14\v\x2\x34\x37\x5\x10\t\x2\x35\x37\x5\n\x6\x2\x36\x31"+
		"\x3\x2\x2\x2\x36\x32\x3\x2\x2\x2\x36\x33\x3\x2\x2\x2\x36\x34\x3\x2\x2"+
		"\x2\x36\x35\x3\x2\x2\x2\x37\x39\x3\x2\x2\x2\x38:\x5\b\x5\x2\x39\x38\x3"+
		"\x2\x2\x2\x39:\x3\x2\x2\x2:\t\x3\x2\x2\x2;>\a\x6\x2\x2<=\a:\x2\x2=?\a"+
		"\x37\x2\x2><\x3\x2\x2\x2>?\x3\x2\x2\x2?@\x3\x2\x2\x2@\x46\t\x4\x2\x2\x41"+
		"\x42\a\x38\x2\x2\x42\x43\a\x39\x2\x2\x43\x44\a)\x2\x2\x44G\a\x34\x2\x2"+
		"\x45G\a;\x2\x2\x46\x41\x3\x2\x2\x2\x46\x45\x3\x2\x2\x2G\v\x3\x2\x2\x2"+
		"HI\a\x5\x2\x2IJ\t\x5\x2\x2JK\a)\x2\x2K}\a\x35\x2\x2LS\a\x5\x2\x2MN\a\""+
		"\x2\x2NT\x5\x14\v\x2OQ\a#\x2\x2PR\x5\n\x6\x2QP\x3\x2\x2\x2QR\x3\x2\x2"+
		"\x2RT\x3\x2\x2\x2SM\x3\x2\x2\x2SO\x3\x2\x2\x2TU\x3\x2\x2\x2U}\a(\x2\x2"+
		"VW\a\x5\x2\x2WX\a\x1A\x2\x2XY\a)\x2\x2YZ\a\x35\x2\x2Z`\x5\b\x5\x2[\\\a"+
		"\x5\x2\x2\\]\a\x1B\x2\x2]^\a)\x2\x2^_\a\x35\x2\x2_\x61\x5\b\x5\x2`[\x3"+
		"\x2\x2\x2`\x61\x3\x2\x2\x2\x61\x66\x3\x2\x2\x2\x62\x63\a\x5\x2\x2\x63"+
		"\x64\a\x1C\x2\x2\x64\x65\a(\x2\x2\x65g\x5\b\x5\x2\x66\x62\x3\x2\x2\x2"+
		"\x66g\x3\x2\x2\x2gh\x3\x2\x2\x2hi\a\x5\x2\x2ij\a\x1D\x2\x2jk\a(\x2\x2"+
		"k}\x3\x2\x2\x2lm\a\x5\x2\x2mn\a\x1E\x2\x2no\a(\x2\x2op\x5\b\x5\x2pq\a"+
		"\x5\x2\x2qr\a\x1F\x2\x2rs\a(\x2\x2s}\x3\x2\x2\x2tu\a\x5\x2\x2uv\a \x2"+
		"\x2vw\a(\x2\x2wx\x5\b\x5\x2xy\a\x5\x2\x2yz\a!\x2\x2z{\a(\x2\x2{}\x3\x2"+
		"\x2\x2|H\x3\x2\x2\x2|L\x3\x2\x2\x2|V\x3\x2\x2\x2|l\x3\x2\x2\x2|t\x3\x2"+
		"\x2\x2}\r\x3\x2\x2\x2~\x7F\a\a\x2\x2\x7F\x87\a\x18\x2\x2\x80\x88\a)\x2"+
		"\x2\x81\x83\a)\x2\x2\x82\x84\a*\x2\x2\x83\x82\x3\x2\x2\x2\x84\x85\x3\x2"+
		"\x2\x2\x85\x83\x3\x2\x2\x2\x85\x86\x3\x2\x2\x2\x86\x88\x3\x2\x2\x2\x87"+
		"\x80\x3\x2\x2\x2\x87\x81\x3\x2\x2\x2\x87\x88\x3\x2\x2\x2\x88\x89\x3\x2"+
		"\x2\x2\x89\x8A\a\x33\x2\x2\x8A\xF\x3\x2\x2\x2\x8B\x8C\a\b\x2\x2\x8C\x11"+
		"\x3\x2\x2\x2\x8D\x8F\a\xE\x2\x2\x8E\x8D\x3\x2\x2\x2\x8F\x90\x3\x2\x2\x2"+
		"\x90\x8E\x3\x2\x2\x2\x90\x91\x3\x2\x2\x2\x91\x13\x3\x2\x2\x2\x92\x9E\x5"+
		"\x12\n\x2\x93\x95\a\r\x2\x2\x94\x93\x3\x2\x2\x2\x95\x96\x3\x2\x2\x2\x96"+
		"\x94\x3\x2\x2\x2\x96\x97\x3\x2\x2\x2\x97\x9E\x3\x2\x2\x2\x98\x9E\a\v\x2"+
		"\x2\x99\x9E\a\x3\x2\x2\x9A\x9E\a\t\x2\x2\x9B\x9E\a\n\x2\x2\x9C\x9E\a\xF"+
		"\x2\x2\x9D\x92\x3\x2\x2\x2\x9D\x94\x3\x2\x2\x2\x9D\x98\x3\x2\x2\x2\x9D"+
		"\x99\x3\x2\x2\x2\x9D\x9A\x3\x2\x2\x2\x9D\x9B\x3\x2\x2\x2\x9D\x9C\x3\x2"+
		"\x2\x2\x9E\xA0\x3\x2\x2\x2\x9F\xA1\x5\x14\v\x2\xA0\x9F\x3\x2\x2\x2\xA0"+
		"\xA1\x3\x2\x2\x2\xA1\x15\x3\x2\x2\x2\x16\x1A %*/\x36\x39>\x46QS`\x66|"+
		"\x85\x87\x90\x96\x9D\xA0";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Twee2Z.Analyzer