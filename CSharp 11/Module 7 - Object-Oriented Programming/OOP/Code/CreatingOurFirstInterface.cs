using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class CreatingOurFirstInterface
    {
        internal interface IMyInterface
        {
            void Method1();
            string Method2(int param1);
            void Method4(string param1, int param2);
            bool MyProperty1 { get; set; }
            int MyReadonlyProperty { get; }
        }

        internal interface IMySecondInterface
        {
            //string brand;
            void MethodFromTheSecondInterface();
        }

        internal class MyClassWithAnInterface : IMyInterface, IMySecondInterface
        {
            public bool MyProperty1 { get; set; }

            public int MyReadonlyProperty => 42;

            public void Method1()
            {
                Console.WriteLine("This is method 1");
            }

            public string Method2(int param1)
            {
                return "Example";
            }

            public void Method4(string param1, int param2)
            {
                throw new NotImplementedException();
            }

            public void MethodFromTheSecondInterface()
            {
                throw new NotImplementedException();
            }
        }

        internal struct MyStruct : IMySecondInterface
        {
            public void MethodFromTheSecondInterface()
            {
                throw new NotImplementedException();
            }
        }

        internal record MyRecord(string param1) : IMySecondInterface
        {
            public void MethodFromTheSecondInterface()
            {
                throw new NotImplementedException();
            }
        }
    }
}
