using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class PropertiesOfType
    {
        public void TheCode()
        {
            Type t = typeof(int);

            int age = 999;
            Type dataTypeOfAge = age.GetType();

            Type dataTypeOfInt = Type.GetType("System.Int32")!;

            Console.WriteLine($"Is {t.Name} an array? {t.IsArray}");

            Console.WriteLine($"The maximum value of an Integer is (without reflection): {int.MaxValue}");

            var value = t.GetField("MaxValue")!.GetValue(default(int));

            Console.WriteLine($"The maximum value of an Integer is (with reflection): {value}");

        }
    }
}
