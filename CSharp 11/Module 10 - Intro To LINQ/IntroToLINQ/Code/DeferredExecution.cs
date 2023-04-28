using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class DeferredExecution
    {
        public void TheCode()
        {
            int[] numbers = Enumerable.Range(1, 5).ToArray();

            // Example 1: Deferred execution
            var evenNumbers = numbers.Where(n =>
            {
                Console.WriteLine($"Evaluating if {n} is even");
                return n % 2 == 0;
            });

            PrintNumbers(evenNumbers);

            Console.WriteLine();

            // Example 2: Non-Deferred execution
            var evenNumbers2 = numbers.Where(n =>
            {
                Console.WriteLine($"Evaluating if {n} is even");
                return n % 2 == 0;
            }).ToList();

            PrintNumbers(evenNumbers2);

            Console.WriteLine("The end");
        }

        private void PrintNumbers(IEnumerable<int> evenNumbers)
        {
            foreach (var number in evenNumbers)
            {
                Console.WriteLine($"Yes, {number} is even");
            }
        }
    }
}
