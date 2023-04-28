using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class ToStringFunction
    {
        public void TheCode()
        {
            var num1 = 6;

            if (num1.ToString() == "5")
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }

            var todayIsSunday = true;

            Console.WriteLine($"The variable todayIsSunday is equal to {todayIsSunday.ToString()}");

            if (todayIsSunday.ToString() == "True")
            {
                Console.WriteLine("Today is Sunday");
            }

            Console.WriteLine("The end");
        }
    }
}
