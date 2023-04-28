using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class Methods
    {
        internal class Car
        {
            // Fields
            private string? _brand;

            // Properties
            internal string? Brand
            {
                get { return _brand!.ToUpper(); }
                set { _brand = value; }
            }

            // Auto-implemented property
            internal int Year { get; set; } = 1990;

            internal int Speed { get; private set; } = 20;

            private int MaximumSpeed => 120;

            // Brand (Year)
            internal string CommercialName => $"{Brand} ({Year})";

            internal void Accelerate()
            {
                Accelerate(1);
            }

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

        public void TheCode()
        {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Year = 2022;

            Console.WriteLine($"Speed before accelerating: {car1.Speed}");
            car1.Accelerate();
            car1.Accelerate();

            Console.WriteLine($"Speed after accelerating: {car1.Speed}");

            var car2 = new Car();
            car2.Accelerate(15);

            Console.WriteLine("The speed of car 2 is: " + car2.Speed);
        }
    }
}
