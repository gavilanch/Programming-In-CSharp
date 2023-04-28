using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class Negation
    {
        public void TheCode()
        {
            var todayIsSunday = false;

            todayIsSunday = !todayIsSunday;

            Console.WriteLine(todayIsSunday);
        }
    }
}
