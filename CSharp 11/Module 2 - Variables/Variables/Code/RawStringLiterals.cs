using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class RawStringLiterals
    {
        public void TheCode()
        {
            string myFirstRSL = """"Hello, """nice""" to \ meet you, I am Felipe"""";

            Console.WriteLine(myFirstRSL);

            string letter = """
                To whom it may concern,

                Dear client, you owe me money. The bank says: "pay us"

                Att: The administration
                """;


            Console.WriteLine(letter);

        }
    }
}
