using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class Constants
    {
        public void TheCode()
        {
            var num1 = 1;
            num1 = 2;

            const int myConstant = 7;

            //myConstant = 9; // error: We cannot change a constant

            const string myValue = "Felipe";

            //myValue = "Gavilán"; // error: We cannot change a constant

            Console.WriteLine(myConstant);

            const double conversionFactorKilometersPerHourToMetersPerSeconds = 3.6;

            var speedKPH = 100;
            var speedMPS = speedKPH / conversionFactorKilometersPerHourToMetersPerSeconds;
        }
    }
}
