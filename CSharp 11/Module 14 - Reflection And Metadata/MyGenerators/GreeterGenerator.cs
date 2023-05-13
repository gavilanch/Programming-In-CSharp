using Microsoft.CodeAnalysis;
using System;

namespace MyGenerators
{
    [Generator]
    public class GreeterGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var sourceCode = @"
namespace ReflectionAndMetadata
{
    static partial class Greeter
    {
        static partial void GeneratedGreet(string name) =>
                Console.WriteLine($""The generator says: Hello, {name}, how are you?"");
    }
}

";

            context.AddSource("Greeter.g.cs", sourceCode);
        }

       
    }
}
