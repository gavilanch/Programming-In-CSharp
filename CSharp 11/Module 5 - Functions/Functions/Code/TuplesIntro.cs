using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class TuplesIntro
    {
        public void TheCode()
        {
            // Example 1: Simple use of Tuple

            (int felipesAge, int claudiasAge, string myName, bool todayIsSunday) myTuple 
                = (99, 45, "Felipe", true);

            Console.WriteLine(myTuple);

            Console.WriteLine(myTuple.felipesAge);
            Console.WriteLine(myTuple.claudiasAge);
            Console.WriteLine(myTuple.myName);
            Console.WriteLine(myTuple.todayIsSunday);

            // Example 2: Returning several values from a function

            (int doubled, int tripled) DoubleAndTriple(int value)
            {
                return (value * 2, value * 3);
            }

            var value = 10;
            var result = DoubleAndTriple(value);
            Console.WriteLine(result);

        }
    }
}
