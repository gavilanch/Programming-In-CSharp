using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class PropertyPattern
    {
        public void TheCode()
        {
            // Example 1: Simple use

            string firstName = "Felipe";

            if (firstName is { Length: 6 })
            {
                Console.WriteLine("The string has 6 characters");
            }

            if (firstName.Length == 6)
            {
                Console.WriteLine("The string has 6 characters");
            }

            // Example 2: Pattern with several properties

            var car = new Car("Mercedes");
            car.Year = 2015;

            switch (car)
            {
                case
                { Brand: "TOYOTA" or "Hyunday", Year: > 2010 }:
                    Console.WriteLine("You have a good car!");
                    break;
                case
                { Brand: "Mercedes", Speed: > 25 }:
                    Console.WriteLine("You are going fast in your mercedes");
                    break;
                case
                { Year: < 2000 }:
                    Console.WriteLine("That car has lasted a long time!");
                    break;
            }

            // Example 3: Properties of properties

            if (car is { Brand.Length: > 6 })
            {
                Console.WriteLine("The brand name is very long");
            }
            else
            {
                Console.WriteLine("The brand name is very short");
            }

            Console.WriteLine("The end");
        }

        internal class Car
        {
            // Fields
            private string _brand;

            // Constructors

            internal Car() : this("default brand")
            {
                Console.WriteLine("Instantiating a car");
            }

            internal Car(string brand)
            {
                Console.WriteLine("Instantiating a car with a brand");
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
