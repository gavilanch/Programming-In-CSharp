using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class ExplicitAndImplicitConversions
    {
        public void TheCode()
        {
            // Example 1: From int to double
            var num1 = 7;
            var num2 = 4;

            var division = (double)num1 / num2;

            Console.WriteLine($"The division is {division}");

            // Example 2: From int to byte.

            byte byte1; // 0 to 255
            int int1 = 3; // - 2 billion aprox to 2 billion aprox

            byte1 = (byte)int1;

            // Example 3: From byte to int. The casting can be implicit.

            byte byte2 = 7;
            int int2;

            int2 = byte2;

            Console.WriteLine("The end");
        }
    }
}
