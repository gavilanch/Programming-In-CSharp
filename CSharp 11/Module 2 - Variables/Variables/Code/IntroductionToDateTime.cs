using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class IntroductionToDateTime
    {
        public void TheCode()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now);

            DateTime firstDayOfTheYear = new DateTime(2023, 1, 1, 7, 15, 23);

            Console.WriteLine(firstDayOfTheYear);

            DateTime tomorrow = DateTime.Now.AddDays(1);

            Console.WriteLine(tomorrow);

            Console.WriteLine("The day is:");
            Console.WriteLine(now.Day);

            Console.WriteLine("The day of the year is:");
            Console.WriteLine(now.DayOfYear);

            Console.WriteLine("The day of the week is:");
            Console.WriteLine(now.DayOfWeek);


            var august15 = new DateTime(2023, 8, 15);

            Console.WriteLine("The day of the year of august 15 is:");
            Console.WriteLine(august15.DayOfYear);
        }
    }
}
