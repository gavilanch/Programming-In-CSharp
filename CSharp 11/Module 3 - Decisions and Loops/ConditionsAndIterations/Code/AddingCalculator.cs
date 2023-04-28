using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class AddingCalculator
    {
        public void TheCode()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the sum calculator in C#!");
                Console.Write("Write the first number: ");
                var userInput = Console.ReadLine();

                if (userInput is null)
                {
                    Console.WriteLine("Error. Try again");
                    continue;
                }

                var num1 = int.Parse(userInput);

                Console.Write("Write the second number: ");
                userInput = Console.ReadLine();

                if (userInput is null)
                {
                    Console.WriteLine("Error. Try again");
                    continue;
                }

                var num2 = int.Parse(userInput);

                Console.WriteLine($"The result of adding {num1} and {num2} is {num1 + num2}");

                Console.Write("Do you wish to add again? (y/n) ");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("The end");
        }
    }
}
