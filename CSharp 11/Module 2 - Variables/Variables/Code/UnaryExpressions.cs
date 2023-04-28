using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class UnaryExpressions
    {
        public void TheCode()
        {
            var num1 = 7;

            var num1MultipliedByMinus1 = -num1; // (-1) * num1;

            //Console.WriteLine(num1MultipliedByMinus1);

            //num1++; // num1 = num1 + 1
            //num1--; // num1 = num1 - 1

            //++num1; // num1 = num1 + 1
            //--num1; // num1 = num1 - 1

            Console.WriteLine(num1);
            num1++;

            Console.WriteLine(num1);
        }
    }
}
