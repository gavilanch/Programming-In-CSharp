using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class YieldAndInfiniteLoops
    {
        public void TheCode()
        {
            IEnumerable<int> value2 = Add2(2).Take(30);
            IEnumerable<int> value3 = Add2(3).Take(50);

            foreach (var value in Add2(7))
            {
                Console.WriteLine(value);
            }


            IEnumerable<int> Add2(int value)
            {
                for (; ; )
                {
                    value += 2;
                    yield return value;
                }
            }
        }
    }
}
