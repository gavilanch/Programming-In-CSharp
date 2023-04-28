using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class Comments
    {
        public void TheCode()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            // This code writes a message in the console
            Console.WriteLine("I am Claudia; Mi age is 123");

            // I did this to explain to my students what a block of code is.
            // This is line 2 of the comment
            {
                Console.WriteLine("This code is in a block");
            }

            /*
             This is a
            multi-line
            comment
             */

            Console.WriteLine("This code is not in a block");
        }
    }
}
