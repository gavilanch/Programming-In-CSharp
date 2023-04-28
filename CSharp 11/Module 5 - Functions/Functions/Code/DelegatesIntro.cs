using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class DelegatesIntro
    {
        public void TheCode()
        {
            Action action;
            Func<int> func;
            Predicate<int> predicate;

            bool TryParse2(string value, out int result)
            {
                return int.TryParse(value, out result);
            }

            //Func<string, out int, bool> tryParseFunc = TryParse2;

            TryParseDelegate myDelegate = TryParse2;

            int value;

            if (myDelegate("12", out value))
            {
                Console.WriteLine(++value);
            }

        }

        delegate bool TryParseDelegate(string value, out int result);
    }
}
