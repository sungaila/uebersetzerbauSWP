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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Twee"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.4.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface ITweeVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] Twee.StartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.ignoreFirst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIgnoreFirst([NotNull] Twee.IgnoreFirstContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.passage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassage([NotNull] Twee.PassageContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.passageContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassageContent([NotNull] Twee.PassageContentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.link"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLink([NotNull] Twee.LinkContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.macro"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacro([NotNull] Twee.MacroContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.macroBranchIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroBranchIf([NotNull] Twee.MacroBranchIfContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.macroBranchIfElse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroBranchIfElse([NotNull] Twee.MacroBranchIfElseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.macroBranchElse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroBranchElse([NotNull] Twee.MacroBranchElseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.macroBranchPop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacroBranchPop([NotNull] Twee.MacroBranchPopContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] Twee.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] Twee.FunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] Twee.VariableContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.zeichenkette"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitZeichenkette([NotNull] Twee.ZeichenketteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Twee.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitText([NotNull] Twee.TextContext context);
}
} // namespace Twee2Z.Analyzer
