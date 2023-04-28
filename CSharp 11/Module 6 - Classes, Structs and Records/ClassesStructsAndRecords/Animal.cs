using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
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
}
