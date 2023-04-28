using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class DoWhileLoop
    {
        public void TheCode()
        {
            int counter = 11;

            //while (counter <= 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++; // counter = counter + 1
            //}

            do
            {
                Console.WriteLine(counter);
                counter++; // counter = counter + 1
            } while (counter <= 10);

            Console.WriteLine("The end");
        }
    }
}
