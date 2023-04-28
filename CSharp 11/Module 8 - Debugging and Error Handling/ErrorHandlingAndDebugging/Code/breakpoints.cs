using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class breakpoints
    {
        public void TheCode()
        {
            var lastName = "Gavilán";

            var myVariable = 1;
            myVariable++;

            Add(4, 6);

            Console.WriteLine("The end");

            int Add(int a, int b)
            {
                int c = a + b;
                return c;
            }

        }
    }
}
