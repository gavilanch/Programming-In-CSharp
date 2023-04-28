using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class OrderByAndOrderByDescending
    {
        public void TheCode()
        {
            // Example 1: Order by element

            int[] numbers = { 1, 5, 12, 2, 3, 111, 6 };

            var orderedNumbers = numbers.OrderBy(x => x).ToList();
            var orderedNumbers2 = numbers.OrderByDescending(x => x).ToList();

            // Example 2: Order by property

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

            foreach (var person in people.OrderByDescending(x => x.Age))
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old");
            }

            Console.WriteLine("The end");
        }
    }
}
