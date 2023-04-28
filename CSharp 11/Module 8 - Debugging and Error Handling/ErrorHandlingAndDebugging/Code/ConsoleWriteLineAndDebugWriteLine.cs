using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class ConsoleWriteLineAndDebugWriteLine
    {
        public void TheCode()
        {
            var myWriter = new TextWriterTraceListener(Console.Out);
            Trace.Listeners.Add(myWriter);

            Console.WriteLine("This line has been executed");

            var amount1 = 4;

            Console.WriteLine($"The value of the variable is: {amount1}");

            Debug.WriteLine("This message will only appear in debug mode");

        }
    }
}
