using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    internal class Car
    {
        // Fields
        private string _brand;

        // Constructors

        internal Car(): this("default brand")
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
