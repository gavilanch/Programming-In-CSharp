using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class InheritanceWithRecords
    {
        internal record Person
        {
            public string FirstName { get; set; } = null!;
            public string LastName { get; set; } = null!;
        }

        internal record Teacher : Person
        {
            public string[]? Subjects { get; set; }
        }

        internal record PersonPositional(string FirstName, string LastName);

        internal record TeacherPositional(string FirstName, string LastName, string[]? Subjects) :
                PersonPositional(FirstName, LastName);

        internal record TeacherNominal2 : PersonPositional
        {
            public TeacherNominal2(string FirstName, string LastName) : base(FirstName, LastName)
            {
            }

            public string[]? Subjects { get; set; }
        }
    }
}
