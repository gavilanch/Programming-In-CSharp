using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class PropertiesPart1
    {
        internal class Car
        {
            // Field
            private string? _brand;
            private int _year;

            internal string? Brand
            {
                get { return _brand!.ToUpper(); }
                set { _brand = value; }
            }

            internal int Year
            {
                get { return _year; }
                set { _year = value; }
            }
        }

        public void TheCode()
        {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Year = 2022;

            var car2 = new Car();
            car2.Brand = "Honda";
            car2.Year = 2021;

            ModifyBrand(car1);
            Console.WriteLine($"Car 1's brand: {car1.Brand}");
            Console.WriteLine(car1.Year);

            Console.WriteLine($"Car 2's brand: {car2.Brand}");

            void ModifyBrand(Car car)
            {
                car.Brand += "2";
            }
        }
    }
}
