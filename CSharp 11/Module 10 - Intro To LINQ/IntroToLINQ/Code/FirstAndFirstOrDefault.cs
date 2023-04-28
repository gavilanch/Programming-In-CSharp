using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class FirstAndFirstOrDefault
    {
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

            var firstPerson = people.First();
            var firstPerson2 = people.FirstOrDefault();

            var countries = new List<string>();

            //var firstCountry = countries.First();
            var firstCountry2 = countries.FirstOrDefault();

            var firstPersonYoungerThan25 = people.First(p => p.Age < 25);
            var firstPersonOlderThan100 = people.FirstOrDefault(p => p.Age > 100);
            var firstPersonOlderThan100_2 = people.Where(p => p.Age > 100).FirstOrDefault();

            Console.WriteLine("The end");
        }
    }
}
