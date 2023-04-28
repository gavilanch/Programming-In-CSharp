using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class PredicateIntro
    {
        public void TheCode()
        {
            bool IsEven(int n)
            {
                return n % 2 == 0;
            }

            Predicate<int> predicate = IsEven;

            var num1 = 4;
            Console.WriteLine($"Is {num1} even? {predicate(num1)}");

            var num2 = 5;
            Console.WriteLine($"Is {num2} even? {predicate(num2)}");
        }
    }
}
