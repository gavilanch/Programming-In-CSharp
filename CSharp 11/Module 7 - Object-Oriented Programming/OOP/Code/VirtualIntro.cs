using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class VirtualIntro
    {
        internal class Vehicule
        {
            public string? Brand { get; set; }
            public int Year { get; set; }

            public virtual void GoInReverse()
            {
                Console.WriteLine("Going in reverse - default implementation");
            }
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
            public override void GoInReverse()
            {
                base.GoInReverse();
                Console.WriteLine("BEEP! BEEP! BEEP!");
            }
        }

        internal class Bicycle : Vehicule
        {

        }

        public void TheCode()
        {
            var car = new Car();
            var truck = new Truck();
            var bicycle = new Bicycle();

            Console.WriteLine("Car:");
            car.GoInReverse();
            Console.WriteLine("--");

            Console.WriteLine("Truck:");
            truck.GoInReverse();
            Console.WriteLine("--");

            Console.WriteLine("Bicycle:");
            bicycle.GoInReverse();
            Console.WriteLine("--");
        }
    }
}
