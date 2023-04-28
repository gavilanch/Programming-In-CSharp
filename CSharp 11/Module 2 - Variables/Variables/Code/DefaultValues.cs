using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class DefaultValues
    {
        public void TheCode()
        {
            int age = default;

            Console.WriteLine("Default value of int:");
            Console.WriteLine(age);

            age = 8;

            Console.WriteLine("Default value of bool:");
            Console.WriteLine(default(bool));

            Console.WriteLine("Default value of decimal:");
            Console.WriteLine(default(decimal));

            Console.WriteLine("Default value of DateTime:");
            Console.WriteLine(default(DateTime));

            Console.WriteLine("Default value of string:");
            Console.WriteLine(default(string));
        }
    }
}
