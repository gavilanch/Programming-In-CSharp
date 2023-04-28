using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class AnonymousTypes
    {
        public void TheCode()
        {
            // Normal class
            var car = new Car() { Brand = "Toyota", Year = 2005 };

            // Anonymous type
            var person = new { FirstName = "Felipe", LastName = "Gavilán", Age = 999 };

            var mutatedPerson = person with { Age = 100 };

            var myVariable = "Felipe";

            var anonymousCar = new { car.Brand, car.Year, myVariable };

            //person.FirstName = "Robert";

            //Console.WriteLine(person.FirstName);

            //Console.WriteLine(person);

            //Console.WriteLine(anonymousCar);

            Console.WriteLine("Mutated person: " + mutatedPerson);

            Console.WriteLine("The end");
        }

        internal class Car
        {
            // Fields
            private string _brand;

            // Constructors

            internal Car() : this("default brand")
            {
                //Console.WriteLine("Instantiating a car");
            }

            internal Car(string brand)
            {
                //Console.WriteLine("Instantiating a car with a brand");
                _brand = brand;
                InstancesCount++;
            }

            // Properties
            internal string Brand
            {
                get { return _brand!.ToUpper(); }
                set { _brand = value; }
            }

            internal static int InstancesCount { get; set; }

            // Auto-implemented property
            internal int Year { get; set; } = 1990;

            internal int Speed { get; private set; } = 20;

            private int MaximumSpeed => 120;

            // Brand (Year)
            internal string CommercialName => $"{Brand} ({Year})";

            internal void Accelerate()
            {
                //InstancesCount = 7;
                Accelerate(1);
            }

            // Overload
            internal void Accelerate(int increment)
            {
                if (Speed >= MaximumSpeed)
                {
                    Console.WriteLine("Maximum speed limit has been reached");
                    return;
                }
                else if (Speed + increment > MaximumSpeed)
                {
                    increment = MaximumSpeed - Speed;
                }

                Speed += increment;
            }

            internal void Stop() => Speed = 0;
        }
    }
}
