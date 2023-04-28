using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class RealNumbers
    {
        public void TheCode()
        {
            float height = 180.123456789F; // Occupies 4 bytes; Precision of 6 to 9 digits
            double width = 45.123456789; // Occupies 8 bytes; Precision of 15 to 17 digits
            decimal amount = 9.99m; // Occupies 16 bytes; Precision 28 to 29 digits (It is recommended for things related to money)

            Console.WriteLine("The height is:");
            Console.WriteLine(height);

            Console.WriteLine("The width is:");
            Console.WriteLine(width);

            Console.WriteLine("The amount is:");
            Console.WriteLine(amount);

        }
    }
}
