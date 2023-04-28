using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class Parameters
    {
        public void TheCode()
        {
            // Example 1: A function that receives a single parameter

            int Double(int value)
            {
                return value * 2;
            }

            void PrintTheDoubleOfANumber(int n)
            {
                var result = Double(n);
                Console.WriteLine($"The double of {n} is {result}");
            }

            //PrintTheDoubleOfANumber(5);
            //PrintTheDoubleOfANumber(6);

            // Example 2: A function that receives two parameters

            decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }

            var sum = Add(1.1m, 2.3m); // 3.4

            // Example 3: Several parameters of diff data types

            void PrintOnTheConsole(string message, int times)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            PrintOnTheConsole("C# is awesome!", 5);
            PrintOnTheConsole("We are learning a lot!", 3);
        }
    }
}
