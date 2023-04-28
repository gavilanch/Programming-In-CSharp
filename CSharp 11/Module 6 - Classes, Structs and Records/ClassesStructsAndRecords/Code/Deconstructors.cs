using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class Deconstructors
    {
        internal class ResultDT
        {
            public int Value { get; set; }
            public int Doubled { get; set; }
            public int Tripled { get; set; }

            internal void Deconstruct(out int value, out int doubled, out int tripled)
            {
                value = Value;
                doubled = Doubled;
                tripled = Tripled;
            }
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

            var (value, doubled, tripled) = resultDT;

            Console.WriteLine($"The value is {value}");
            Console.WriteLine($"The double is {doubled}");
            Console.WriteLine($"The triple is {tripled}");
        }
    }
}
