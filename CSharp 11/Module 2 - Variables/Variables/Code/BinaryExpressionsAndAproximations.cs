using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class BinaryExpressionsAndAproximations
    {
        public void TheCode()
        {
            var num1 = 7.1m;
            var num2 = 3.5m;

            var sum = num1 + num2;
            var substraction = num1 - num2;
            var product = num1 * num2;
            var division = num1 / num2;
            var remainder = num1 % num2;

            Console.WriteLine("The sum is in decimal: " + sum);
            Console.WriteLine("The subtraction is in decimal: " + substraction);
            Console.WriteLine("The product is in decimal: " + product);
            Console.WriteLine("The division is in decimal: " + division);
            Console.WriteLine("The remainder is in decimal: " + remainder);

            Console.WriteLine("---");

            var num1double = 7.1;
            var num2double = 3.5;

            var sumdouble = num1double + num2double;
            var substractiondouble = num1double - num2double;
            var productdouble = num1double * num2double;
            var divisiondouble = num1double / num2double;
            var remainderdouble = num1double % num2double;

            Console.WriteLine("The sum is in double: " + sumdouble);
            Console.WriteLine("The subtraction is in double: " + substractiondouble);
            Console.WriteLine("The product is in double: " + productdouble);
            Console.WriteLine("The division is in double: " + divisiondouble);
            Console.WriteLine("The remainder isin double: " + remainderdouble);
        }
    }
}
