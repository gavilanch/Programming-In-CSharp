using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class DistinctAndDistinctBy
    {
        public void TheCode()
        {
            var people = new List<Person>() {
    new Person{ Name = "Eduardo", CompanyId = 1, },
    new Person { Name = "Nidia", CompanyId = 1 },
    new Person { Name = "Eduardo" },
    new Person { Name = "Esmerlin", CompanyId = 3 }
};

            int[] numbers = { 1, 2, 3, 1, 1, 6 };

            var numbersWithoutRepetition = numbers.Distinct();

            var peopleWithoutTheSameName = people.DistinctBy(p => p.Name);

            Console.WriteLine("The end");
        }
    }
}
