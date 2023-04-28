using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class SelectFunction
    {
        internal class PersonDTO
        {
            public string Name { get; set; } = null!;
            public int Age { get; set; }
        }

        public void TheCode()
        {
            var people = new List<Person>() {
    new Person {
        Name = "Eduardo",
        Age = 30,
        DateJoinedTheCompany = new DateTime(2021, 1, 2),
        IsSingle = true },
    new Person {
        Name = "Nidia",
        Age = 19,
        DateJoinedTheCompany = new DateTime(2015, 11, 22),
        IsSingle = true },
    new Person {
        Name = "Alejandro",
        Age = 45,
        DateJoinedTheCompany = new DateTime(2020, 4, 12),
        IsSingle = false },
    new Person {
        Name = "Valentina",
        Age = 24,
        DateJoinedTheCompany = new DateTime(2021, 7, 8),
        IsSingle = false },
    new Person {
        Name = "Roberto",
        Age = 61,
        DateJoinedTheCompany = DateTime.Now.AddDays(-1),
        IsSingle = false },
};

            // Example 1: Selecting a single property
            var names = people.Select(p => p.Name).ToList();

            // Example 2: Selecting several properties
            var namesAndAges = people.Select(p => new { p.Name, p.Age }).ToList();

            // Example 3: Projecting to a class
            var personDTOs = people.Select(p => new PersonDTO { Name = p.Name, Age = p.Age }).ToList();

            // Example 4: Math operation
            var numbers = Enumerable.Range(1, 5).ToList();
            var numbersDouble = numbers.Select(n => 2 * n).ToList();

            // Example 5: Using the index

            foreach (var item in people.Select((person, index) => new { Name = person.Name, Index = index + 1 }))
            {
                Console.WriteLine($"{item.Index}) {item.Name}");
            }

            Console.WriteLine("The end");
        }
    }
}
