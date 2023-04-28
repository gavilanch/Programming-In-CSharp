using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal class PolymorphismWithInterfaces
    {

        internal interface IMySecondInterface
        {
            void MethodFromTheSecondInterface();
        }

        internal class ClassA : IMySecondInterface
        {

            public void MethodFromClassA()
            {

            }

            public void MethodFromTheSecondInterface()
            {
                Console.WriteLine("Implementation of class A");
            }
        }

        internal class ClassB : IMySecondInterface
        {
            public void MethodFromTheSecondInterface()
            {
                Console.WriteLine("Implementation of class B");
            }
        }

        public void TheCode()
        {
            var classA = new ClassA();
            var classB = new ClassB();

            Process(classA);
            Process(classB);


            void Process(IMySecondInterface mySecondInterface)
            {
                mySecondInterface.MethodFromTheSecondInterface();
            }

            Console.WriteLine("The end");
        }
    }
}
