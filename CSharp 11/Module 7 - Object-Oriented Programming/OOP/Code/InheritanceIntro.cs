using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class InheritanceIntro
    {
        internal class Vehicule
        {
            public string? Brand { get; set; }
            public int Year { get; set; }
        }

        internal class Car : Vehicule
        {
            public void TurnOnRadio()
            {
                Console.WriteLine("Turning on the radio");
            }
        }

        internal class Truck : Vehicule
        {

        }

        internal class Bicycle : Vehicule
        {

        }

        public void TheCode()
        {
            var car = new Car();
            car.Brand = "Toyota";
            car.TurnOnRadio();

            var truck = new Truck();
            truck.Brand = "Mercedes";

            var bicycle = new Bicycle();
            bicycle.Brand = "Scott";

            ReadBrand(car);
            ReadBrand(truck);
            ReadBrand(bicycle);

            void ReadBrand(Vehicule vehicule)
            {
                var message = $"Reading the brand {vehicule.Brand} of the vehicule of type {vehicule}";
                Console.WriteLine(message);
            }
        }
    }
}
