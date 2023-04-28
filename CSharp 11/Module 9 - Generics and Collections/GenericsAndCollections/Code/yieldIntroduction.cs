using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class yieldIntroduction
    {
        public void TheCode()
        {
            var enumerableOfNumbers = FirstThreeNumbers();

            var firstNumber = enumerableOfNumbers.First();

            var firstTwoNumbers = enumerableOfNumbers.Take(2);

            foreach (var number in enumerableOfNumbers)
            {
                Console.WriteLine(number);
            }

            var listOfNumbers = enumerableOfNumbers.ToList();

            Console.WriteLine("The end");

            IEnumerable<int> FirstThreeNumbers()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }
        }
    }
}
