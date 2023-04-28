using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
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
}
