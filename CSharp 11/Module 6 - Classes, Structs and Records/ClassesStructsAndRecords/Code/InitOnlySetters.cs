using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class InitOnlySetters
    {
        internal class ClassWithImmutableProperties
        {
            public int Property1 { get; init; }
            public string? Property2 { get; init; }
            public bool Property3 { get; init; }
        }

        public void TheCode()
        {
            var myClass = new ClassWithImmutableProperties()
            {
                Property3 = true,
                Property1 = 2,
                Property2 = "Felipe"
            };

            //myClass.Property1 = 1;

            Console.WriteLine("The end");
        }
    }
}
