using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class ElvisOperator
    {
        public void TheCode()
        {
            int[]? numbers = { 1, 2 };

            numbers = null;

            Console.WriteLine($"The length is: {numbers?.Length}");
        }
    }
}
