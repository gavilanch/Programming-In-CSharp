using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class IntroductionToGenerics
    {
        internal class ArrayUtilities<T> : IArrayUtilities<T>
        {
            public int ComputeLengthOfArray(T[] array)
            {
                return array.Length;
            }

            public T? FirstElementOrDefault(T[] array)
            {
                if (array.Length == 0)
                {
                    return default;
                }

                return array[0];
            }
        }

        interface IArrayUtilities<T>
        {
            int ComputeLengthOfArray(T[] array);
            T? FirstElementOrDefault(T[] array);
        }

        public void TheCode()
        {

            int[] numbers = { 1, 2, 3 };

            string[] names = { "Felipe", "Claudia", "Pedro", "Juana" };

            DateTime[] dates = { DateTime.Today, DateTime.Today.AddDays(1) };

            // Example 1: Length of the array

            //Console.WriteLine($"The length of the number's array is: {ComputeLengthOfArray(numbers)}");

            //Console.WriteLine($"The length of the name's array is: {ComputeLengthOfArray(names)}");

            //Console.WriteLine($"The length of the date's array is: {ComputeLengthOfArray(dates)}");

            // Example 2: First element

            numbers = new int[0];
            names = new string[0];
            dates = new DateTime[0];

            Console.WriteLine($"The first element of the number's array is: {FirstElementOrDefault(numbers)}");

            Console.WriteLine($"The first element of the names's array is: {FirstElementOrDefault(names)}");

            Console.WriteLine($"The first element of the date's array is: {FirstElementOrDefault(dates)}");

            // Example 3: Generic classes

            var utilitiesArrayInts = new ArrayUtilities<int>();
            utilitiesArrayInts.ComputeLengthOfArray(numbers);

            var utilitiesArrayStrings = new ArrayUtilities<string>();
            utilitiesArrayStrings.ComputeLengthOfArray(names);


            int ComputeLengthOfArray<T>(T[] array)
            {
                return array.Length;
            }

            T? FirstElementOrDefault<T>(T[] array)
            {
                if (array.Length == 0)
                {
                    return default;
                }

                return array[0];
            }
        }
    }
}
