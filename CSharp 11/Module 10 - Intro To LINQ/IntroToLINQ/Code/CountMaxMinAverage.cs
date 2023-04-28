using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class CountMaxMinAverage
    {
        public void TheCode()
        {
            var people = new List<Person>() {
new Person { Name = "Eduardo", IsSingle = true, Age = 19 },
new Person { Name = "Nidia", IsSingle = true, Age = 25 },
new Person { Name = "Alejandro", IsSingle = true, Age = 30 },
new Person { Name = "Valentina", IsSingle = false, Age = 22 }
};

            Console.WriteLine($"The amount of people is: {people.Count()}");
            Console.WriteLine($"The amount of people that are single is: {people.Count(p => p.IsSingle)}");

            var numbers = Enumerable.Range(1, 5);

            var sum = numbers.Sum();
            var sumOfAges = people.Sum(p => p.Age);

            var min = numbers.Min();
            var minAge = people.Min(p => p.Age);

            var max = numbers.Max();
            var maxAge = people.Max(p => p.Age);

            var average = numbers.Average();
            var averageAge = people.Average(p => p.Age);


            Console.WriteLine("The end");
        }
    }
}
