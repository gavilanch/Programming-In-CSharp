using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class UsingParams
    {
        public void TheCode()
        {
            // Example 1: Passing a normal array

            double Average(int[] numbers)
            {
                var sum = 0.0;
                foreach (var number in numbers)
                {
                    sum += number;
                }

                return sum / numbers.Length;
            }

            Console.WriteLine(Average(new int[] { 1, 5, 7, 2 }));

            // Example 2: Using params

            double Average2(params int[] numbers)
            {
                var sum = 0.0;
                foreach (var number in numbers)
                {
                    sum += number;
                }

                return sum / numbers.Length;
            }

            Console.WriteLine(Average2(1, 5, 7, 2));
        }
    }
}
