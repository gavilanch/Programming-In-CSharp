using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class Selectionstatements_if
    {
        public void TheCode()
        {
            var num1 = 4;

            if (num1 > 5)
            {
                Console.WriteLine("num1 is greater than 5");
                Console.WriteLine("Processing...");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("num1 is 3");
            }
            else
            {
                Console.WriteLine("num1 is less than or equal to 5");
            }

            Console.WriteLine("The end");
        }
    }
}
