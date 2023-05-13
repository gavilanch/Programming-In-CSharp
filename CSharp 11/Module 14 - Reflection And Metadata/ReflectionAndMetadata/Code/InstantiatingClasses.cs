using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class InstantiatingClasses
    {
        internal class Person
        {
            public Person()
            {

            }

            public Person(string name)
            {
                Name = name;
            }

            public string? Name { get; set; }
        }

        public void TheCode()
        {
            // Example 1: Instantiating a class by the type

            var personWithoutNameViaType = (Person)Activator.CreateInstance(typeof(Person))!;
            personWithoutNameViaType.Name = "Felipe";

            Console.WriteLine($"Person instantiated by the type: " + personWithoutNameViaType.Name);

            // Example 2: Instantiating a class by the name and assembly

            var fullNameOfPerson = typeof(Person).FullName!;
            var assemblyOfPersonClass = typeof(Person).Assembly.GetName().Name!;

            var personWithoutNameViaString = (Person)Activator.CreateInstance(assemblyOfPersonClass, fullNameOfPerson)!.Unwrap()!;

            Console.WriteLine($"Person instantiated by its name " + personWithoutNameViaString);

            // Example 3: Instantiating a class passing values to its constructor

            var personWithNameViaType = (Person)Activator.CreateInstance(typeof(Person), new object[] { "Claudia" })!;
            Console.WriteLine($"Person instantiated by the type: " + personWithNameViaType.Name);

        }
    }
}
