using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class OutParameters
    {
        public void TheCode()
        {
            // Example 1: Simple use of out

            int numberToDouble = 5;
            int doubledNumber;

            void Double(int n, out int doubled)
            {
                doubled = n * 2;
            }

            Double(numberToDouble, out doubledNumber);

            //Console.WriteLine("Original number: " + numberToDouble);
            //Console.WriteLine("Doubled number: " + doubledNumber);

            // Example 2: "Returning" several values using out

            void DoubleAndTriple(int number, out int doubledNumber, out int tripledNumber)
            {
                doubledNumber = number * 2;
                tripledNumber = number * 3;
            }

            int doubled, tripled;

            DoubleAndTriple(7, out doubled, out tripled);

            Console.WriteLine("The double is " + doubled);
            Console.WriteLine("The triple is " + tripled);

            // Example 3: TryParse

            int number;
            string numberString = "Felipe";

            if (int.TryParse(numberString, out number))
            {
                Console.WriteLine("The number is " + number);
            }
            else
            {
                Console.WriteLine("Incorrect format");
            }
        }
    }
}
