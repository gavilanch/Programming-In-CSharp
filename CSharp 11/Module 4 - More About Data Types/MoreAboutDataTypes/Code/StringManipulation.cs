using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class StringManipulation
    {
        public void TheCode()
        {
            var firstName = "Felipe";
            var lastName = "Gavilán";
            // Example 1: Casing

            Console.WriteLine(firstName.ToUpper()); // FELIPE
            Console.WriteLine(firstName.ToLower()); // felipe

            // Some folks do FELIPE == firstName.ToUpper()
            if (firstName.Equals("FELIPE", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Your name is Felipe");
            }
            else
            {
                Console.WriteLine("Your name is not Felipe");
            }

            // Example 2: Length

            Console.WriteLine($"The length of {firstName} is {firstName.Length}");

            // Example 3: Removing stuff with Trim

            var firstNameWithSpaces = "    Felipe    ";
            Console.WriteLine($"{firstNameWithSpaces.Trim()} {lastName}");

            // Example 4: Removing stuff with Replace

            var identificationNumber = "123-456789-0";

            Console.WriteLine(identificationNumber.Replace("-", ""));

            // Example 5: Pad

            long amount1 = 123; // 0000000123
            long amount2 = 4;
            long amount3 = 123456789L;
            long amount4 = 1234567890L;

            Console.WriteLine(amount1.ToString().PadLeft(10, '0'));
            Console.WriteLine(amount2.ToString().PadLeft(10, '0'));
            Console.WriteLine(amount3.ToString().PadLeft(10, '0'));
            Console.WriteLine(amount4.ToString().PadLeft(10, '0'));
        }
    }
}
