using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
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
}
