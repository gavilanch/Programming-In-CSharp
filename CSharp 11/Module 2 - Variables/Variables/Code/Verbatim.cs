using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class Verbatim
    {
        public void TheCode()
        {
            string letter = @"To whom it may concern,

Dear client, you owe me money. The bank says: ""pay us""

Att: The administration";

            string fileDirectory = @"C:\My documents\My folder\myfile.xlsx";

            Console.WriteLine(letter);
            Console.WriteLine(fileDirectory);
        }
    }
}
