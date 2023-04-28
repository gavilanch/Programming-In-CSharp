using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class IEnumerableIntroduction
    {
        public void TheCode()
        {
            var numbers = new List<int> { 1, 2, 3 };

            var names = new string[] { "Felipe", "Claudia" };

            PrintInConsole(numbers);

            Console.WriteLine();

            PrintInConsole(names);


            void PrintInConsole<T>(IEnumerable<T> values)
            {
                foreach (var value in values)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
