using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class NullCoalesceOperator
    {
        public void TheCode()
        {
            // Example 1: Simple use

            int[]? numbers = { 1, 2 };

            numbers = null;

            //                EXPRESSION ?? VALUE-IF-EXPRESSION-IS-NULL
            var length = numbers?.Length ?? 0;

            //Console.WriteLine(length);

            // Example 2: Changing the value of the variable

            numbers ??= new int[] { };

            Console.WriteLine($"Is it null? {numbers is null}");
            Console.WriteLine($"Is it an empty array? {numbers?.Length == 0}");
        }
    }
}
