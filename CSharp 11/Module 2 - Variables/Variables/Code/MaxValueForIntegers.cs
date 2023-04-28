using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class MaxValueForIntegers
    {
        public void TheCode()
        {
            int maxValueForIntegers = int.MaxValue;
            int minValueForIntegers = int.MinValue;

            int maxValueForIntegers2 = 2_147_483_647;

            //int superBigNumber = 10000000000000000000000000000000000000;

            Console.WriteLine(maxValueForIntegers);
            Console.WriteLine(maxValueForIntegers2);
            Console.WriteLine(minValueForIntegers);
        }
    }
}
