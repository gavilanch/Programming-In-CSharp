using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class Quantifiers
    {
        public void TheCode()
        {
            var people = new List<Person>() {
new Person { Name = "Eduardo", IsSingle = true, Age = 19 },
new Person { Name = "Nidia", IsSingle = true, Age = 25 },
new Person { Name = "Alejandro", IsSingle = true, Age = 30 },
new Person { Name = "Valentina", IsSingle = false, Age = 22 }
};

            var isEveryPerson18orOlder = people.All(p => p.Age >= 18);
            var isEveryPersonSingle = people.All(p => p.IsSingle);

            var isAnyoneNotSingle = people.Any(p => !p.IsSingle);
            var isAnyoneOver35 = people.Any(p => p.Age > 35);

            var numbers = Enumerable.Range(1, 5);

            var isNumber3Contained = numbers.Contains(3);
            var isNumber20Contained = numbers.Contains(20);
            var isEduardoContainedInPeople = people.Contains(new Person { Name = "Eduardo", IsSingle = true, Age = 19 });
        }
    }
}
