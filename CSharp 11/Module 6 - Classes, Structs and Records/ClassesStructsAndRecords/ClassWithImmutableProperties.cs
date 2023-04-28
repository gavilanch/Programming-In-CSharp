using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
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
}
