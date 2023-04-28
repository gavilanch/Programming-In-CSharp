using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class OutputTypeAsClass
    {
        internal class ResultDT
        {
            public int Value { get; set; }
            public int Doubled { get; set; }
            public int Tripled { get; set; }
        }

        internal ResultDT ComputeDoubleAndTriple(int value)
        {
            var result = new ResultDT();

            result.Value = value;
            result.Doubled = value * 2;
            result.Tripled = value * 3;

            return result;
        }

        internal class Calculator
        {
            internal ResultDT ComputeDoubleAndTriple(int value)
            {
                var result = new ResultDT();

                result.Value = value;
                result.Doubled = value * 2;
                result.Tripled = value * 3;

                return result;
            }
        }

        public void TheCode()
        {
            var calculator = new Calculator();

            var resultDT = calculator.ComputeDoubleAndTriple(5);

            Console.WriteLine($"The value is {resultDT.Value}");
            Console.WriteLine($"The double is {resultDT.Doubled}");
            Console.WriteLine($"The triple is {resultDT.Tripled}");
        }
    }
}
