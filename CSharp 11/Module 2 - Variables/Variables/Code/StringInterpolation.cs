using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class StringInterpolation
    {
        public void TheCode()
        {
            var num1 = 7;
            var num2 = 4;
            var sum = num1 + num2;

            var firstName = "Felipe";
            var lastName = "Gavilán";

            var result = $"{firstName} {lastName}"; // Felipe Gavilán

            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine(result);
        }
    }
}
