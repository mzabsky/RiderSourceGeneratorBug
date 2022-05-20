using Microsoft.CodeAnalysis;

namespace SourceGeneratorImpl
{
    [Generator]
    public class SourceGenerator: ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            string rootNamespace;
            if (!context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.RootNamespace", out rootNamespace))
            {
                rootNamespace = "NotFound";
            }

            var masterSource = $"public static class GeneratedClass {{ public static string {rootNamespace} = \"Hello\"; }}";
            context.AddSource("Generated.cs", masterSource);
        }
    }
}
