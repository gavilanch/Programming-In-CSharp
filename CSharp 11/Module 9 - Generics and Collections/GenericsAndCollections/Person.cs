using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
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
}
