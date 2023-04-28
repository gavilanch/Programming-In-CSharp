using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Base1
    {
        public int Base1Prop { get; set; }
    }

    internal class Base2: Base1
    {
        public int Base2Prop { get; set; }
    }

    internal class Derived: Base2
    {
        public int DerivedProp { get; set; }

        void Method()
        {
            DerivedProp = 1;
            Base2Prop = 2;
            Base1Prop = 3;
        }
    }

    internal class SubDerived : Derived
    {
        public int SubDerivedProp { get; set; }
    }
}
