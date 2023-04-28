using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class ParametersAsReference
    {
        public void TheCode()
        {
            // Example 1: using ref for value types

            int num1 = 5;

            void Double(ref int n)
            {
                n *= 2;
                Console.WriteLine("The value inside of the function is " + n);
            }

            Console.WriteLine("The value outside of the function is " + num1);
            Double(ref num1);
            Console.WriteLine("The value outside of the function is " + num1);

            // Example 2: passing a reference type

            var originalArray = new int[] { 1, 2, 3 };

            void DoubleArray(int[] values)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] *= 2;
                }
            }

            void PrintArray(int[] values)
            {
                foreach (var value in values)
                {
                    Console.Write($"{value} ");
                }
            }

            Console.Write("Values of the array before doubling: ");
            PrintArray(originalArray);

            Console.WriteLine();

            DoubleArray(originalArray);
            Console.Write("Values of the array after doubling: ");
            PrintArray(originalArray);
        }
    }
}
