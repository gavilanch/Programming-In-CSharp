using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class LambdaExpressions
    {
        public void TheCode()
        {
            int Sum(int a, int b)
            {
                return a + b;
            }

            int Sum2(int a, int b) => a + b;

            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum2(1, 2));
        }
    }
}
