using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class LogicalPatterns
    {
        public void TheCode()
        {
            // Example 1: Not

            string? lastName = "Gavilán";

            if (lastName is not null)
            {
                Console.WriteLine(lastName.ToUpper());
            }

            // Example 2: And

            var temperature = 38;

            var message = temperature switch
            {
                37 => "You are fine!",
                > 37 and < 39 => "You have fever!",
                >= 39 and < 43 => "You must go to the doctor",
                >= 43 => "omae wa mou shindeiru",
                < 37 => "You may be low on sugar"
            };

            Console.WriteLine(message);

            // Example 3: or

            var season = DateTime.Today.Month switch
            {
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Fall",
                12 or 1 or 2 => "Winter",
                _ => throw new NotImplementedException()
            };

            Console.WriteLine(season);

            Console.WriteLine("The end");
        }
    }
}
