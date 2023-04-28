using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class BinaryExpressions
    {
        public void TheCode()
        {
            var num1 = 7;
            var num2 = 4;
            var sum = num1 + num2;
            var sum2 = 7 + 4;

            var substract = num1 - num2;
            var product = num1 * num2;
            var division = (double)num1 / num2;
            var remainder = num1 % num2;

            Console.WriteLine("The sum is:");
            Console.WriteLine(sum);

            Console.WriteLine("The substraction is:");
            Console.WriteLine(substract);

            Console.WriteLine("The product is:");
            Console.WriteLine(product);

            Console.WriteLine("The division is:");
            Console.WriteLine(division);

            Console.WriteLine("The remainder is:");
            Console.WriteLine(remainder);
        }
    }
}
