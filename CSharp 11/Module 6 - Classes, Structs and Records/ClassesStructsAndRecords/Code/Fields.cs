using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class Fields
    {
        internal class Car
        {
            // Field
            internal string? _brand;
            internal int _year;
        }

        public void TheCode()
        {
            // Just like we can have several strings
            string firstName = "Felipe";
            string lastName = "Gavilán";

            // We can have several "instances" of the Car class.
            Car car1 = new Car();
            car1._brand = "Toyota";
            car1._year = 2022;

            var car2 = new Car();
            car2._brand = "Honda";
            car2._year = 2021;

            // Classes are reference types
            car2 = null;

            ModifyBrand(car1);
            Console.WriteLine(car1._brand);
            Console.WriteLine(car1._year);

            void ModifyBrand(Car car)
            {
                car._brand += "2";
            }
        }
    }
}
