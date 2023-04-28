using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class CallStackWindow
    {
        public void TheCode()
        {

            ClassA.ProcessA();
        }

        internal class ClassA
        {
            public static void ProcessA()
            {
                ClassB.ProcessB();
            }
        }

        internal class ClassB
        {
            public static void ProcessB()
            {
                ClassC.ProcessC();
            }
        }

        internal class ClassC
        {
            public static void ProcessC()
            {

            }
        }
    }
    
}
