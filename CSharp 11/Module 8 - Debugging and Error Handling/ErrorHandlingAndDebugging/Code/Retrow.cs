using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class Retrow
    {
        public void TheCode()
        {
            try
            {
                ClassA.ProcessA();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some more processing...");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The end");
        }

        internal class ClassA
        {
            public static void ProcessA()
            {
                try
                {
                    throw new NotImplementedException();
                }
                catch (Exception)
                {
                    Console.WriteLine("Processing the exception...");
                    throw;
                }
            }
        }
    }
}
