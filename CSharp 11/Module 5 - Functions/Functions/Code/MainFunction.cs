using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class MainFunction
    {
        public int TheCode(string[] args)
        {
            Console.WriteLine($"Receiving {args.Length} arguments in the console");

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            return 21;
        }
    }
}
