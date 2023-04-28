using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class RequiredMembers
    {
        internal class ClassWithImmutableProperties
        {
            [SetsRequiredMembers]
            public ClassWithImmutableProperties()
            {
                Property2 = "Felipe";
            }

            public required int Property1 { get; init; }
            public required string? Property2 { get; init; }
            public bool Property3 { get; init; }
        }

        public void TheCode()
        {
            var myClass = new ClassWithImmutableProperties()
            {
                Property3 = true,
                Property1 = 2
            };

            Console.WriteLine(myClass.Property2);

            Console.WriteLine("The end");
        }
    }
}
