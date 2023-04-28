using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class EqualityIntro
    {
        public void TheCode()
        {
            var resultDT1 = Calculator.ComputeDoubleAndTriple(5);
            var resultDT2 = Calculator.ComputeDoubleAndTriple(5);

            var areTheClassInstancesEqual = resultDT1 == resultDT2;

            Console.WriteLine($"Are the instances equal? {areTheClassInstancesEqual}");

            // Example 2: Structs

            var pointA = new Point(1, 2);
            var pointB = new Point(1, 2);

            // Error
            //var areTheStructInstancesEqual = pointA == pointB;

        }
    }
}
