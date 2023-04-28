using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class GreaterThanLessThan
    {
        public void TheCode()
        {
            var num1 = 5;

            var num2 = 6;

            var isNum2GreaterThanNum1 = num2 > num1;

            var isNum2LessThanNum1 = num2 < num1;

            var isNum2GreaterThanOrEqualToNum1 = num2 >= num1;

            var isNum2LessThanOrEqualToNum1 = num2 <= num1;

            Console.WriteLine($"Is {num2} greater than {num1}? {isNum2GreaterThanNum1}");

            Console.WriteLine($"Is {num2} less than {num1}? {isNum2LessThanNum1}");

            Console.WriteLine($"Is {num2} greater than or equal to {num1}? {isNum2GreaterThanOrEqualToNum1}");

            Console.WriteLine($"Is {num2} less than or equal to {num1}? {isNum2LessThanOrEqualToNum1}");

            var date1 = new DateTime(2023, 1, 1);
            var date2 = new DateTime(2024, 1, 1);

            Console.WriteLine($"Is {date2} greater than {date1}? {date2 > date1}");
        }
    }
}
