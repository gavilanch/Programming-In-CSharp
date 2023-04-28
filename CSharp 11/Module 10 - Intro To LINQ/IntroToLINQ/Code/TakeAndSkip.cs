using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class TakeAndSkip
    {
        public void TheCode()
        {
            var numbers = Enumerable.Range(1, 100);

            var first10Numbers = numbers.Take(10).ToList();
            var second10Numbers = numbers.Skip(10).Take(10).ToList();

            var last10Numbers = numbers.TakeLast(10).ToList();
            var secondToLast10Numbers = numbers.SkipLast(10).TakeLast(10).ToList();

            Console.WriteLine("The end");
        }
    }
}
