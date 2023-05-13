using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class BaseTypesAndInterfaces
    {
        public void TheCode()
        {
            // Example 1: Getting the base type

            var baseTypeOfCar = typeof(Car).BaseType;
            var baseTypeOfString = typeof(string).BaseType;

            //Console.WriteLine("The base type of car is " + baseTypeOfCar);
            //Console.WriteLine("The base type of string is " + baseTypeOfString);

            // Example 2: Getting the interfaces

            Console.WriteLine("The interfaces of string are: ");

            foreach (var item in typeof(string).GetInterfaces())
            {
                //Console.WriteLine(item.Name);
            }

            // Example 3: Does a type inherit from a specific class or interface?

            var stringType = typeof(string);
            var iEnumerableType = typeof(IEnumerable);

            var stringImplementsIEnumerable = stringType.IsAssignableTo(iEnumerableType);

            Console.WriteLine("Does string implements IEnumerable? " + stringImplementsIEnumerable);

            var isEnumerableAnInterfaceOfString = iEnumerableType.IsAssignableFrom(stringType);
            Console.WriteLine("Is IEnumerable an interface of string? " + stringImplementsIEnumerable);

            Console.WriteLine("Does car inherits from vehicle? " + typeof(Car).IsAssignableTo(typeof(Vehicle)));
            Console.WriteLine("Does car inherits from IEnumerable? " + typeof(Car).IsAssignableTo(typeof(IEnumerable)));
        }
    }
}
