using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class ExpandoObjectIntroduction
    {
        public void TheCode()
        {
            dynamic expandoObject = new ExpandoObject();

            expandoObject.Name = "Felipe";

            Console.WriteLine(expandoObject.Name);

            expandoObject.LastName = "Gavilán";

            Console.WriteLine(expandoObject.LastName);

            expandoObject.Sum = new Func<int, int, int>((int a, int b) => a + b);

            Console.WriteLine(expandoObject.Sum(1, 2));

            var dictionary = (IDictionary<string, object>)expandoObject;

            Console.WriteLine(dictionary["Name"]);

            Console.WriteLine("The keys before removing LastName are: ");

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(" - " + key);
            }

            dictionary.Remove("LastName");

            Console.WriteLine("The keys after removing LastName are: ");

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(" - " + key);
            }

            try
            {
                Console.WriteLine(expandoObject.LastName);
            }
            catch (Exception)
            {
                Console.WriteLine("The lastname property does not exist");
            }
        }
    }
}
