using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class AbstractIntro
    {
        internal abstract class Vehicule
        {
            public string? Brand { get; set; }
            public int Year { get; set; }
            public int Speed { get; private set; }
            public abstract int MaximumSpeed { get; }

            internal void Accelerate(int increment = 1)
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

            public virtual void GoInReverse()
            {
                Console.WriteLine("Going in reverse - default implementation");
            }

            public abstract void SoundHorn();
        }

        internal class Car : Vehicule
        {
            public override int MaximumSpeed => 80;

            public override void SoundHorn()
            {
                Console.WriteLine("BIP BIP");
            }

            public void TurnOnRadio()
            {
                Console.WriteLine("Turning on the radio");
            }
        }

        internal class Truck : Vehicule
        {
            public override int MaximumSpeed => 70;

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

        internal class Bicycle : Vehicule
        {
            public override int MaximumSpeed => 20;

            public override void SoundHorn()
            {
                Console.WriteLine("Tirín");
            }
        }

        public void TheCode()
        {
            // Can't instatiate the vehicule class because it's abstract
            //var vehicule = new Vehicule();

            var car = new Car();
            car.Accelerate(100);
            Console.WriteLine("The speed of the car is " + car.Speed);

            var bicycle = new Bicycle();
            bicycle.Accelerate(100);
            Console.WriteLine("The speed of the bicycle is " + bicycle.Speed);
        }
    }
}
