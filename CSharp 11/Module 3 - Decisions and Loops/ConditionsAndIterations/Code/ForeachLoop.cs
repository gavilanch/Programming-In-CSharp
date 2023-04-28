using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class ForeachLoop
    {
        public void TheCode()
        {
            var firstName = "Felipe";

            foreach (var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("The end");
        }
    }
}
