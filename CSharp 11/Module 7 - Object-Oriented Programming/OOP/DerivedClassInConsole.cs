using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace OOP
{
    internal class DerivedClassInConsole: PublicClassForTesting
    {
        void Method()
        {
            ProtectedProperty = 15;
            ProtectedInternalProperty = 16;
            //PrivateProtectedProperty = 17;
        }
    }
}
