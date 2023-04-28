using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class AssignmentOperators
    {
        public void TheCode()
        {
            var num1 = 7;
            var num2 = 5;

            var sum = num1 + num2; // 7+5=12

            Console.WriteLine(num1);

            num1 += num2; // num1 = num1 + num2 = 7 + 5 = 12

            num1 -= num2; // num1 = num1 - num2 = 7 - 5 = 2

            num1 *= num2; // num1 = num1*num2

            num1 /= num2; // num1 = num1/num2

            num1 %= num2; // num1 = num1 % num2

            Console.WriteLine(num1);

            var firstName = "Felipe";
            var lastName = "Gavilán";

            firstName += lastName; // firstName = firstName + lastName = FelipeGavilán

            Console.WriteLine(firstName);
        }
    }
}
