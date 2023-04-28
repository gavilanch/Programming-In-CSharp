using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class NullForgivingOperator
    {
        internal class Animal
        {
            public string Name { get; set; } = null!;

            public static void Process(Animal a)
            {
                if (a is null)
                {
                    throw new ArgumentNullException(nameof(a));
                }

                // processing...
            }
        }

        public void TheCode()
        {
            // We are forgiving the null because we are testing the software
            Animal.Process(null!);

            Console.WriteLine("The end");
        }
    }
}
