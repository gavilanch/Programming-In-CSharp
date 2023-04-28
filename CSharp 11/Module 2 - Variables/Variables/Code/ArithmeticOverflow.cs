using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class ArithmeticOverflow
    {
        public void TheCode()
        {
            checked // remove this checked and no exception will be thrown
            {
                var maximum = int.MaxValue;
                var sum = maximum + 1; // error because of arithmetic overflow

                var minimum = int.MinValue;
                var substract = minimum - 1; // error because of arithmetic overflow

                Console.WriteLine("Max: " + maximum);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Min: " + int.MinValue);

            }
        }
    }
}
