using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;
using System.Linq;

namespace Mapper.Analyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class MapperAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "MapperAnalyzer";

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.
        // See https://github.com/dotnet/roslyn/blob/main/docs/analyzers/Localizing%20Analyzers.md for more on localization
        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.AnalyzerTitle), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.AnalyzerMessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.AnalyzerDescription), Resources.ResourceManager, typeof(Resources));
        private const string Category = "Naming";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Error, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            // TODO: Consider registering other actions that act on syntax instead of or in addition to symbols
            // See https://github.com/dotnet/roslyn/blob/main/docs/analyzers/Analyzer%20Actions%20Semantics.md for more information
            context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.GenericName);
        }

        private static void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var genericMapper = (GenericNameSyntax)context.Node;

            if (genericMapper.Identifier.Text == "Map" || genericMapper.Identifier.Text == "MapAsync")
            {
                // For all such symbols, produce a diagnostic.
                var diagnostic = Diagnostic.Create(Rule, genericMapper.GetLocation());

                context.ReportDiagnostic(diagnostic);
            }

            //// TODO: Replace the following code with your own analysis, generating Diagnostic objects for any issues you find
            //var namedTypeSymbol = (INamedTypeSymbol)context.Symbol;

            //// Find just those named type symbols with names containing lowercase letters.
            //if (namedTypeSymbol.Name.ToCharArray().Any(char.IsLower))
            //{
            //    // For all such symbols, produce a diagnostic.
            //    var diagnostic = Diagnostic.Create(Rule, namedTypeSymbol.Locations[0], namedTypeSymbol.Name);

            //    context.ReportDiagnostic(diagnostic);
            //}
        }

        private static void AnalyzeMissingMappers(CodeBlockAnalysisContext codeBlockContext)
        {
            // We only care about method bodies.
            if (codeBlockContext.OwningSymbol.Kind != SymbolKind.Method)
            {
                return;
            }

            // Report diagnostic for void non-virtual methods with empty method bodies.
            IMethodSymbol method = (IMethodSymbol)codeBlockContext.OwningSymbol;
            BlockSyntax block = (BlockSyntax)codeBlockContext.CodeBlock.ChildNodes().FirstOrDefault(n => n.IsKind(SyntaxKind.Block));
            //if (method. && !method.IsVirtual && block != null && block.Statements.Count == 0)
            //{
            //    SyntaxTree tree = block.SyntaxTree;
            //    Location location = method.Locations.First(l => tree.Equals(l.SourceTree));
            //    Diagnostic diagnostic = Diagnostic.Create(Rule, location, method.Name);
            //    codeBlockContext.ReportDiagnostic(diagnostic);
            //}
        }
    }
}
