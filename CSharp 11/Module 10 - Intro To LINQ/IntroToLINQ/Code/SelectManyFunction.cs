using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class SelectManyFunction
    {
        public void TheCode()
        {
            var people = new List<Person>() {
new Person { Name = "Eduardo", PhoneNumbers = { "123-456", "789-852" } },
new Person { Name = "Nidia", PhoneNumbers = { "998-478", "568-222" } },
new Person { Name = "Alejandro", PhoneNumbers = { "712-132" } },
new Person { Name = "Valentina" }
};

            //var wrongSolution = people.Select(p => p.PhoneNumbers).ToList();

            // Example 1: Flatten the phones in a single collection

            var phoneNumbers = people.SelectMany(p => p.PhoneNumbers).ToList();

            // Example 2: Pairing two collections

            int[] numbers = { 1, 2, 3 };

            var peopleAndNumbers = people.SelectMany(p => numbers, (person, number) => new
            {
                Person = person,
                Number = number
            });

            foreach (var item in peopleAndNumbers)
            {
                //Console.WriteLine($"{item.Person.Name} - {item.Number}");
            }

            // Example 3: people and phonenumbers

            var peopleAndPhoneNumbers = people.SelectMany(p => p.PhoneNumbers, (person, phoneNumber) => new
            {
                Person = person,
                PhoneNumber = phoneNumber
            });

            foreach (var item in peopleAndPhoneNumbers)
            {
                Console.WriteLine($"{item.Person.Name} - {item.PhoneNumber}");
            }

            Console.WriteLine("The end");
        }
    }
}
