using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class GroupByFuncion
    {
        public void TheCode()
        {
            var people = new List<Person>() {
new Person { Name = "Eduardo", IsSingle = true },
new Person { Name = "Nidia", IsSingle = true },
new Person { Name = "Alejandro", IsSingle = true },
new Person { Name = "Valentina", IsSingle = false },
new Person { Name = "Roberto", IsSingle = true },
new Person { Name = "Eugenia", IsSingle = false },
new Person { Name = "Esmerlin", IsSingle = false }
};

            var groupedBySingleProperty = people.GroupBy(p => p.IsSingle);

            foreach (var item in groupedBySingleProperty)
            {
                Console.WriteLine($"Group of people where IsSingle = {item.Key} (Total: {item.Count()})");
                foreach (var person in item)
                {
                    Console.WriteLine($"- {person.Name}");
                }
                Console.WriteLine();
            }


            Console.WriteLine("The end");
        }
    }
}
