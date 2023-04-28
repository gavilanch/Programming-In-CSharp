using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class SealedIntro
    {
        internal sealed class CanNotBeDerivedFrom
        {
        }

        //class Derived: CanNotBeDerivedFrom
        //{

        //}

        // Code was abbreviated
        internal abstract class Vehicule
        {
            public string? Brand { get; set; }
            public int Year { get; set; }
            public int Speed { get; private set; }
            public abstract int MaximumSpeed { get; }

            public virtual void GoInReverse()
            {
                Console.WriteLine("Going in reverse - default implementation");
            }

            public abstract void SoundHorn();
        }

        internal class Car : Vehicule
        {
            public override int MaximumSpeed => 80;

            public sealed override void SoundHorn()
            {
                Console.WriteLine("BIP BIP");
            }

            public void TurnOnRadio()
            {
                Console.WriteLine("Turning on the radio");
            }
        }

        internal class GraySonata : Car
        {
            //public override void SoundHorn()
            //{
            //    base.SoundHorn();
            //}
        }
    }
}
