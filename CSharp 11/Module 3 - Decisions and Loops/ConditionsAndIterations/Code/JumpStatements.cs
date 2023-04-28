using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class JumpStatements
    {
        public void TheCode()
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    //break; // this finishes the loop
                    continue; // this skips the current iteration and continue with the next one
                }

                Console.WriteLine(i);
            }


            Console.WriteLine("The end");
        }
    }
}
