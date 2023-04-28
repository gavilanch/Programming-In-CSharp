using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class NamespacesIntro
    {
        public void TheCode()
        {
            var resultDT = Calculator.ComputeDoubleAndTriple(10);

            //var calculator = new ClassesStructsAndRecords.Mathematics.Calculator();
            //calculator.CalculatePi();
        }
    }

    internal static class Calculator
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
}
