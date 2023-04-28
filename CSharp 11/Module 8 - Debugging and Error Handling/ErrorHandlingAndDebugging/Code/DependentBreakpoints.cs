using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class DependentBreakpoints
    {
        public void TheCode()
        {
            MethodB();
            MethodA();
            MethodB();

            void MethodA()
            {

            }

            void MethodB()
            {

            }
        }
    }
}
