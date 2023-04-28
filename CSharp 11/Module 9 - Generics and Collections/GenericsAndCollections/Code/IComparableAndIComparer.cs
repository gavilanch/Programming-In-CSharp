using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class IComparableAndIComparer
    {
        internal class Person : IComparable<Person>
        {
            public string Name { get; set; } = null!;
            public int Age { get; set; }

            public int CompareTo(Person? other)
            {
                if (other is null)
                {
                    throw new ArgumentNullException(nameof(other));
                }

                // Explanation: If the value is < 0, then the person goes first
                // If the value is > 0, then the person goes second
                // if the value is 0, then they have the same "size"

                return other.Age - Age;
            }
        }

        internal class ComparerOfPersonByName : IComparer<Person>
        {
            private readonly StringComparison stringComparison;

            public ComparerOfPersonByName(StringComparison stringComparison = StringComparison.Ordinal)
            {
                this.stringComparison = stringComparison;
            }

            public int Compare(Person? x, Person? y)
            {
                if (x is null || x.Name is null)
                {
                    throw new ArgumentNullException($"The parameter {nameof(x)} or {nameof(x.Name)} is null");
                }

                if (y is null || y.Name is null)
                {
                    throw new ArgumentNullException($"The parameter {nameof(y)} or {nameof(y.Name)} is null");
                }

                return string.Compare(x.Name, y.Name, stringComparison);
            }
        }

        internal void TheCode()
        {
            var alice = new Person { Name = "Alice", Age = 25 };
            var bob = new Person { Name = "Bob", Age = 26 };

            var value = alice.CompareTo(bob);

            //Console.WriteLine(value);

            var people = new List<Person>()
{
    alice,
    new Person(){Name = "Robert", Age = 15},
    new Person(){Name = "Lorena", Age = 25},
    new Person(){Name = "Mario", Age = 22},
    bob,
    new Person(){Name = "Jessica", Age = 15}
};

            // Sort by age
            people.Sort();
            // Sort by name
            people.Sort(new ComparerOfPersonByName());

            foreach (var person in people)
            {
                Console.WriteLine($"- {person.Name} (Age: {person.Age})");
            }
        }
    }
}
