using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    internal class ClientInsideOfLibrary
    {
        public void Testing()
        {
            var publicClass = new PublicClassForTesting();
            publicClass.InternalProperty = 2;
            publicClass.ProtectedInternalProperty = 3;
            //publicClass.PrivateProtectedProperty = 8;
            //publicClass.ProtectedProperty = 2;
            //publicClass.PrivateMethod();

            //var internalClass = new InternalClass();

            //var myFileClass = new MyFileClass();
        }
    }

    internal class DerivedClassInTheSameLibrary: PublicClassForTesting
    {
        public void Testing()
        {
            PrivateProtectedProperty = 8;
        }
    }
}
