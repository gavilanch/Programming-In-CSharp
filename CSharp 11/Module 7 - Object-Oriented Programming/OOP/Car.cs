using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
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

    internal class Car: Vehicule
    {
        public Car(string brand) : base(brand)
        {
        }

        public override int MaximumSpeed => 80;

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

    internal class GraySonata : Car
    {
        //public override void SoundHorn()
        //{
        //    base.SoundHorn();
        //}
        public GraySonata(string brand) : base(brand)
        {
        }
    }

    internal class Truck: Vehicule
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
}
