using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class BooleanExpressions
    {
        public void TheCode()
        {
            bool todayIsSunday = false; // booleans can be true or false

            var num1 = 5; // assignment

            var num2 = 5; // assignment

            var isNum1EqualToNum2 = num1 == num2; // equality operator

            var isNum1DifferentFromNum2 = num1 != num2; // inequality operator

            Console.WriteLine($"Is {num1} equal to {num2}? {isNum1EqualToNum2}");

            Console.WriteLine($"Is {num1} different from {num2}? {isNum1DifferentFromNum2}");
        }
    }
}
