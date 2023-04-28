using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class OperatorPrecedence
    {
        public void TheCode()
        {
            var num1 = 1;
            var num2 = 2;
            var num3 = 3;

            var num4 = num1 + num2 + num3; // 1 + 2 + 3 = 6

            // Multiplication is done first
            var num5 = num1 + num2 * num3;
            // 1 + 2 * 3 = 1 + 6 = 7 CORRECT

            var num6 = (num1 + num2) * num3; // 9

            var num7 = num1 + num2;
            var num8 = num7 * num3; // It is not confusing anymore

            Console.WriteLine(num5);
        }
    }
}
