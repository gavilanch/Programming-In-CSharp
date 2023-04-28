using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class AnonymousFunctions
    {
        public void TheCode()
        {
            void PrintDateAndTime()
            {
                Console.WriteLine(DateTime.Now);
            }

            Action printMessage = PrintDateAndTime;

            // Example 1: A simple anonymous function

            Action printMessage2 = () => {
                Console.WriteLine(DateTime.Now);
            };

            //printMessage2();

            // Example 2: Passing an anonymous function as a parameter

            void Process(Action action)
            {
                Console.WriteLine("Before executing the function");
                action();
                Console.WriteLine("After executing the function");
            }

            Process(() =>
            {
                Console.WriteLine(DateTime.Now);
            });

            // Example 3: Anonymous function that receives a parameter and returns a value

            Func<int, int> doubleNumber = a => 2 * a;

            // Example 4: Anonymous function that receives 2 parameters and returns a value

            Func<bool, string, int> example = (bool1, string1) =>
            {
                return 42;
            };

            var example2 = (bool bool1, string string1) => 42;
        }
    }
}
