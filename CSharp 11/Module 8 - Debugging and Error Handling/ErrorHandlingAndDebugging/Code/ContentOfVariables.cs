using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class ContentOfVariables
    {
        public void TheCode()
        {
            Process(7, "Gavilán");

            void Process(int a, string lastName)
            {
                var tuple = (a, lastName);
                a = 3;
                int b = a + 8;
                b -= 4;
                int[] numbers = { 1, 2, 3 };
            }

        }
    }
}
