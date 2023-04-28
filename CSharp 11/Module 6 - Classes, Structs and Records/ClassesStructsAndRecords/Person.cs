using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    // Nominal record
    internal record Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }

    // Positional record
    internal readonly record struct Company(string Name, int foundationYear);
}
