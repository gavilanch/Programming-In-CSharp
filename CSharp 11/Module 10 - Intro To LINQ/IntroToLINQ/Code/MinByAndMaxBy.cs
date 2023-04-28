using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class MinByAndMaxBy
    {
        public void TheCode()
        {
            var people = new List<Person>() {
new Person { Name = "Eduardo", IsSingle = true, Age = 19 },
new Person { Name = "Nidia", IsSingle = true, Age = 25 },
new Person { Name = "Alejandro", IsSingle = true, Age = 30 },
new Person { Name = "Valentina", IsSingle = false, Age = 22 }
};

            var minAge = people.Min(p => p.Age);
            var maxAge = people.Max(p => p.Age);

            var personWithSmallestAge = people.MinBy(p => p.Age);
            var personWithBiggestAge = people.MaxBy(p => p.Age);

            Console.WriteLine("The end");
        }
    }
}
