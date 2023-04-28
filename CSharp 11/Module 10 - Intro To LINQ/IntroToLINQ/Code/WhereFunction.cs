using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class WhereFunction
    {
        public void TheCode()
        {

            // Example 1: Where with numbers
            var numbers = Enumerable.Range(1, 20).ToList();

            var oddNumbers = numbers.Where(n => n % 2 == 1).ToList();

            var evenNumbersGreaterThan10 = numbers.Where(n => n % 2 == 0 && n > 10).ToList();

            // Example 2: Where with more complex objects

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

            var peopleWithAge25OrLess = people.Where(p => p.Age <= 25).ToList();

            foreach (var person in peopleWithAge25OrLess)
            {
                //Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

            var singlePeople = people.Where(p => p.IsSingle).ToList();

            foreach (var person in singlePeople)
            {
                //Console.WriteLine($"{person.Name} is single");
            }

            var singleLessThan25 = people.Where(p => p.IsSingle && p.Age <= 25).ToList();

            foreach (var person in singleLessThan25)
            {
                //Console.WriteLine($"{person.Name} is single and is less than 25 years old.");
            }

            var peopleThatJoinedLessThan3MonthsAgo = people
                                    .Where(p => p.DateJoinedTheCompany >= DateTime.Today.AddMonths(-3))
                                    .ToList();

            foreach (var person in peopleThatJoinedLessThan3MonthsAgo)
            {
                Console.WriteLine($"{person.Name} has less than 3 months in the company.");
            }

            Console.WriteLine("The end");
        }
    }
}
