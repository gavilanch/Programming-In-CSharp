using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class PropertiesPart2
    {
        internal class Car
        {
            // Fields
            private string? _brand;

            // Properties
            internal string? Brand
            {
                get { return _brand!.ToUpper(); }
                set { _brand = value; }
            }

            // Auto-implemented property
            internal int Year { get; set; } = 1990;

            internal int Speed { get; private set; } = 20;

            // Brand (Year)
            internal string CommercialName => $"{Brand} ({Year})";
        }

        public void TheCode()
        {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Year = 2022;

            var car2 = new Car();
            car2.Brand = "Honda";

            ModifyBrand(car1);
            Console.WriteLine(car1.CommercialName);

            void ModifyBrand(Car car)
            {
                car.Brand += "2";
            }
        }
    }
}
