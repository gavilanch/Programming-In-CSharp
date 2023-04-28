using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class GenericRestrictions
    {
        public void TheCode()
        {
            int[] numbers = { 1, 2, 3 };

            // Does have a paramerless constructor
            int myNumber = new int();

            string[] names = { "Felipe", "Claudia", "Pedro", "Juana" };

            // Does not have a paramerless constructor
            //string myString = new string();

            DateTime[] dates = { DateTime.Today, DateTime.Today.AddDays(1) };

            //Console.WriteLine($"The length of the number's array is: {ComputeLengthOfArray(numbers)}");

            //Console.WriteLine($"The length of the name's array is: {ComputeLengthOfArray(names)}");

            //Console.WriteLine($"The length of the date's array is: {ComputeLengthOfArray(dates)}");

            Car[] cars = { new Car() };
            Console.WriteLine($"The length of the car's array is: {ComputeLengthOfArray(cars)}");

            Truck[] trucks = { new Truck("Mercedes") };
            //Console.WriteLine($"The length of the trucks's array is: {ComputeLengthOfArray(trucks)}");


            int ComputeLengthOfArray<T>(T[] array) where T : Vehicle, new()
            {
                return array.Length;
            }

        }
    }
}
