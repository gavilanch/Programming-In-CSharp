using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class WhileLoop
    {
        public void TheCode()
        {

            // Example 1: Counter
            int counter = 11;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++; // counter = counter + 1
            }

            // Example 2: Interest rate

            var amount = 200m;
            var interestRate = 1.07m;
            var counterExample2 = 1;

            while (counterExample2 <= 5)
            {
                amount *= interestRate;
                counterExample2++;
            }

            Console.WriteLine(amount);

            Console.WriteLine("The end");
        }
    }
}
