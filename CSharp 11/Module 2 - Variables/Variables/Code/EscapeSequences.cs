using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class EscapeSequences
    {
        public void TheCode()
        {
            string longText = "My friend once told me: \"You are very cool\". That was nice";

            string longText2 = "We use \\ to start escape sequences";

            Console.WriteLine(longText);

            Console.WriteLine(longText2);
        }
    }
}
