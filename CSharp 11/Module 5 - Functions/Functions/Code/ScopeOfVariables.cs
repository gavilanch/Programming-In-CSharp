using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class ScopeOfVariables
    {
        public void TheCode()
        {
            string name = "Felipe";

            void PrintCurrentDateAndTime()
            {
                var dateAndTime = DateTime.Now;


                var message = $"The time is: {dateAndTime.ToString("yyyy-MM-dd hh:mm:ss")}";
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(message);
                }

                name = "Claudia";

                Console.WriteLine(message);
            }

            PrintCurrentDateAndTime();
            Console.WriteLine(name);

            // I can't access the message variable from here.
            //Console.WriteLine(message);

        }
    }
}
