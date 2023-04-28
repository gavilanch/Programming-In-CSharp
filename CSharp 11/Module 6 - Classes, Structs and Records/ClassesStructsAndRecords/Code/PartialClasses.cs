using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class PartialClasses
    {
        internal static partial class Calculator
        {
            public static double CalculatePi()
            {
                return Math.PI;
            }
        }

        internal static partial class Calculator
        {
            internal static ResultDT ComputeDoubleAndTriple(int value)
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
            Calculator.CalculatePi();
            Calculator.ComputeDoubleAndTriple(10);
        }
    }
}
