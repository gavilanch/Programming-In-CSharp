using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class LocalFunctions
    {
        public void TheCode()
        {
            void MyFunction()
            {
                var value = 5;
                PrintValue(value);
                value++;
                PrintValue(value);

                void PrintValue(int value)
                {
                    Console.WriteLine("The value is " + value);
                }
            }

            MyFunction();
        }
    }
}
