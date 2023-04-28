using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class CreatingOurFirstRecord
    {

        internal record Person
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
        }

        internal record struct PersonStructVersion
        {
            public PersonStructVersion()
            {

            }

            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
        }

        public void TheCode()
        {
            var person1 = new Person() { FirstName = "Felipe", LastName = "Gavilán" };
            var person2 = new Person() { FirstName = "Felipe", LastName = "Gavilán" };

            var areEqual = person1 == person2;

            // Records by default get compiled to classes
            person1 = null;

            Console.WriteLine("Are they equal? " + areEqual);

            Console.WriteLine("The end");
        }
    }
}
