using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class CastingObject
    {
        // Note: The code has been abbreviated
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

            public virtual void GoInReverse()
            {
                Console.WriteLine("Going in reverse - default implementation");
            }

            public abstract void SoundHorn();
        }

        internal class Car : Vehicule
        {
            public Car(string brand) : base(brand)
            {
            }

            public sealed override void SoundHorn()
            {
                Console.WriteLine("BIP BIP");
            }

            public void TurnOnRadio()
            {
                Console.WriteLine("Turning on the radio");
            }

            public override string ToString()
            {
                return "Whatever value I want";
            }
        }

        internal class Truck : Vehicule
        {
            public override void GoInReverse()
            {
                base.GoInReverse();
                Console.WriteLine("BEEP! BEEP! BEEP!");
            }

            public override void SoundHorn()
            {
                Console.WriteLine("PON POOOON");
            }
        }

        public void TheCode()
        {
            var car = new Car("Toyota");

            AcceptAnyParameter(car);

            AcceptAnyParameter(new Truck());

            //AcceptAnyParameter("Felipe");

            AcceptAnyParameter(42);

            //AcceptAnyParameter(DateTime.Today);


            void AcceptAnyParameter(object obj)
            {
                Console.WriteLine("--- Beginning of the method ---");

                //var car = obj as Car;

                if (obj is Car car)
                {
                    Console.WriteLine("The object is a car");
                    car.SoundHorn();
                }
                else if (obj is Truck truck)
                {
                    Console.WriteLine("The object is a truck");
                    truck.GoInReverse();
                }
                else
                {
                    Console.WriteLine($"The object {obj} is not a car");
                }

                Console.WriteLine("--- End of the method ---");
            }
        }
    }
}
