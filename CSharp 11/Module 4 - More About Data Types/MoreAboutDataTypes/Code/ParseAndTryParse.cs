using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class ParseAndTryParse
    {
        public void TheCode()
        {
            // Example 1: Integers

            var numString = "5";

            int num = int.Parse(numString);

            num++;

            Console.WriteLine(num);

            // Example 2: Decimals

            var decimalString = "4.9";

            var decimalAmount = decimal.Parse(decimalString);

            decimalAmount++;

            Console.WriteLine(decimalAmount);

            // Example 3: Booleans

            var booleanString = "true";

            var b = bool.Parse(booleanString);

            if (b)
            {
                Console.WriteLine("Converting from string to boolean");
            }

            // Example 4: Dates

            // YYYY-mm-DD
            var dateString = "2023-02-03";

            var date = DateTime.Parse(dateString);

            Console.WriteLine(date.AddYears(1));

            // Example 5: TryParse

            var fakeNumber = "Felipe"; // TryParse returns false
                                       //var fakeNumber = "7"; // TryParse returns true

            //var num2 = int.Parse(fakeNumber);

            int num2;

            if (int.TryParse(fakeNumber, out num2))
            {
                num2++;
                Console.WriteLine($"num2 is {num2}");
            }
            else
            {
                Console.WriteLine($"The value {fakeNumber} is not a valid number.");
            }


            Console.WriteLine("The end");
        }
    }
}
