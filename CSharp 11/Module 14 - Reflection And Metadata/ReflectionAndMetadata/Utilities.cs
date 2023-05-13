using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata
{
    //[Hide]
    internal class Utilities
    {
        public void PrintCurrentTime()
        {
            Console.WriteLine($"Current time is: {DateTime.Now}");
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine($"Printing the user's message: {message}");
        }

        public string GettingAValue()
        {
            return "Felipe";
        }

        public static void StaticMethod()
        {
            Console.WriteLine("The static method has been invoked.");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("The private method has been invoked.");
        }

    }
}
