using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class ObjectIntro
    {
        public void TheCode()
        {
            var car = new Car("Toyota");
            var truck = new Truck();
            var canNotBeDerivedFrom = new CanNotBeDerivedFrom();

            Console.WriteLine("Car.ToString = " + car.ToString());

            AcceptAnyParameter(car);

            AcceptAnyParameter("Felipe");

            AcceptAnyParameter(42);

            AcceptAnyParameter(new Truck());

            AcceptAnyParameter(DateTime.Today);


            void AcceptAnyParameter(object obj)
            {

            }
        }
    }
}
