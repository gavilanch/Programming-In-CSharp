using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class PositionalRecords
    {
        // Just for reference, a nominal record:
        internal record Person
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
        }

        // Positional records

        // class version 
        internal record Company(string Name, int foundationYear);

        // struct version (readonly is optional if we want to make it immutable)
        internal readonly record struct Company2(string Name, int foundationYear);

        public void TheCode()
        {
            // We can modify a nominal record
            var person1 = new Person() { FirstName = "Felipe", LastName = "Gavilán" };
            person1.FirstName = "Robert";

            var company1 = new Company("Udemy", 2011);

            // Error
            //company1.Name = "Google";

            var (name, year) = company1;

            Console.WriteLine("The end");
        }
    }
}
