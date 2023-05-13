using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class InvokingMethods
    {
        public void TheCode()
        {
            // Example 1: Invoking a void parameterless method

            var type = typeof(Utilities);
            var utilities = Activator.CreateInstance(type);

            type.InvokeMember("PrintCurrentTime", BindingFlags.InvokeMethod, null, utilities,
                new object[] { });

            // Example 2: Invoking a method passing parameters

            type.InvokeMember("PrintMessage", BindingFlags.InvokeMethod, null, utilities,
                new object[] { "Using reflection" });

            // Example 3: Invoking a method the returns a value

            var result = type.InvokeMember("GettingAValue", BindingFlags.InvokeMethod, null, utilities,
                new object[] { });

            Console.WriteLine("We got the value: " + result);

            // Example 4: Invoking a static method

            type.InvokeMember("StaticMethod", BindingFlags.InvokeMethod, null, target: null, new object[] { });

            // Example 5: Invoking a private method

            type.InvokeMember("PrivateMethod", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance,
                null, utilities, new object[] { });
        }
    }
}
