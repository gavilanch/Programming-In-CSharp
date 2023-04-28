using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class ForLoop
    {
        public void TheCode()
        {
            // for loop structure:
            //for (initialization; condition; update the initialized variable)
            //{
            //    block of code
            //}

            for (int counter = 3; counter <= 10; counter = counter + 2)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine("The end");
        }
    }
}
