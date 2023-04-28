using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class DefaultValueForParameters
    {
        public void TheCode()
        {
            // Example 1: Simple example

            void PrintOnTheConsole(string message, int times = 1)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            //PrintOnTheConsole("C# is awesome", 3);

            // Example 2: Using constants

            const int numberOfTimesToPrintOnTheConsoleByDefault = 2;

            void PrintOnTheConsole2(string message, int times = numberOfTimesToPrintOnTheConsoleByDefault)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            void PrintOnTheConsole3(string message, int times = numberOfTimesToPrintOnTheConsoleByDefault)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            // Example 3: Using default

            void PrintOnTheConsole4(string message, bool inUppercase = default)
            {
                if (inUppercase)
                {
                    message = message.ToUpper();
                }

                Console.WriteLine(message);
            }

            PrintOnTheConsole4("C# is awesome");
        }
    }
}
