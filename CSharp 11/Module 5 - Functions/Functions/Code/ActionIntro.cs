using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class ActionIntro
    {
        public void TheCode()
        {
            // Example 1: Void function that does not receive parameters

            Action printMessage;

            void PrintDateAndTime()
            {
                Console.WriteLine(DateTime.Now);
            }

            void PrintMyName()
            {
                Console.WriteLine("Felipe");
            }

            printMessage = PrintDateAndTime;

            printMessage();

            printMessage = PrintMyName;

            printMessage();

            // Example 2: Passing a function as parameter

            void Process(Action action)
            {
                Console.WriteLine("Before executing the action");
                action();
                Console.WriteLine("After executing the action");
            }

            Process(PrintDateAndTime);
            Console.WriteLine();
            Process(PrintMyName);

            // Example 3: Void function that receives a parameter

            Action<int> alterNumber;

            void Add1(int value)
            {
                value++;
                Console.WriteLine("The value + 1 is " + value);
            }

            alterNumber = Add1;
            alterNumber(5);

            // Example 4: Void function that receives 2 parameters

            Action<string, int> printNTimes;

            void Print(string message, int times)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(message);
                }
            }

            printNTimes = Print;

            printNTimes("Felipe", 5);
        }
    }
}
