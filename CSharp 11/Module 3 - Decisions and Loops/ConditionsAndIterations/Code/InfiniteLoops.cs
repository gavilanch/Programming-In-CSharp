using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class InfiniteLoops
    {
        public void TheCode()
        {
            while (true)
            {
                Console.WriteLine("This code will never stop");
                Console.WriteLine($"The second is {DateTime.Now.Second}");
                if (DateTime.Now.Second == 30)
                {
                    break;
                }
            }

            // Doing an infinite loop with the for loop
            //for (; ; )
            //{
            //    Console.WriteLine("This code will never stop");
            //}

            Console.WriteLine("The end");
        }
    }
}
