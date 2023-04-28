using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class Tracepoints
    {
        public void TheCode()
        {
            Add(4, 6);

            int Add(int a, int b)
            {
                int c = a + b;
                return c;
            }
        }
    }
}
