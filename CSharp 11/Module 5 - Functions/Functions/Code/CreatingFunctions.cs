using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class CreatingFunctions
    {
        public void TheCode()
        {
            // Example 1: Simple function

            string GetName()
            {
                return "Claudia";
            }

            var myName = GetName();

            var myName2 = GetName();

            Console.WriteLine("Name 1: " + myName);

            Console.WriteLine("Name 2: " + myName);

            // Example 2: Functions that don't return anything

            void PrintCurrentDateAndTime()
            {
                var dateAndTime = DateTime.Now;
                var message = $"The time is: {dateAndTime.ToString("yyyy-MM-dd hh:mm:ss")}";
                Console.WriteLine(message);
            }

            PrintCurrentDateAndTime();
        }
    }
}
