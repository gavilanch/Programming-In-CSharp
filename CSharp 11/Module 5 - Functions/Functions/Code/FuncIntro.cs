using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class FuncIntro
    {
        public void TheCode()
        {
            // Example 1: Function that returns a string but doesn't receive any parameters

            Func<string> returnsString;

            string GetCurrentDateAndTime()
            {
                return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }

            returnsString = GetCurrentDateAndTime;

            var result = returnsString();
            Console.WriteLine(result);

            void Process(Func<string> func)
            {
                Console.WriteLine("Before");
                var value = func();
                Console.WriteLine("The value is " + value);
                Console.WriteLine("After");
            }

            Process(GetCurrentDateAndTime);

            // Example 2: A func that receives parameters

            Func<int, string> receiveIntReturnsString;

            string GetNameOfTheMonth(int month)
            {
                var date = new DateTime(2023, month, 1);
                return date.ToString("MMMM");
            }

            receiveIntReturnsString = GetNameOfTheMonth;

            var february = receiveIntReturnsString(2);
            Console.WriteLine(february);
        }
    }
}
