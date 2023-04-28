using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class ConstructorInTheBaseClass
    {
        // The code has been abbreviated
        internal abstract class Vehicule
        {
            public Vehicule()
            {

            }

            public Vehicule(string brand)
            {
                Brand = brand;
            }

            public string? Brand { get; set; }
            public int Year { get; set; }
        }

        internal class Car : Vehicule
        {
            public Car(string brand) : base(brand)
            {
            }
        }

        internal class GraySonata : Car
        {
            public GraySonata(string brand) : base(brand)
            {
            }
        }

        internal class Truck : Vehicule
        {
        }

        internal class Bicycle : Vehicule
        {
        }
    }
}
