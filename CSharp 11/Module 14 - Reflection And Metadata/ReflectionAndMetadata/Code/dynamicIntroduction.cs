using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class dynamicIntroduction
    {
        public void TheCode()
        {
            // Example 1: declaring a variable as dynamic
            dynamic name = "Felipe";

            Console.WriteLine(name);
            Console.WriteLine(name.ToUpper());

            name = 99;

            Console.WriteLine(name);
            Console.WriteLine(name.ToUpper());

            // Example 2: Deserializing to dynamic
            var jsonContent = File.ReadAllText(@"C:\Users\ASUS\source\repos\ReflectionAndMetadata\ReflectionAndMetadata\example.json");

            dynamic obj = JsonConvert.DeserializeObject<dynamic>(jsonContent)!;

            Console.WriteLine(obj.name);
            Console.WriteLine(obj.addresses[0].street);
        }
    }
}
