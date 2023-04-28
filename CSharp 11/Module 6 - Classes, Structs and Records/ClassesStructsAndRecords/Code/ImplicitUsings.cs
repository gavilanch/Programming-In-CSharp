using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class ImplicitUsings
    {
        public void TheCode()
        {
            Console.WriteLine("Where's the using System;?");

            var (value, doubled, tripled) = Calculator.ComputeDoubleAndTriple(5);

            Console.WriteLine(doubled);

            // Note: you can find the global using configuration code in the csproj file.
        }
    }
}
