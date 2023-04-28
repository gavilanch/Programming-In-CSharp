using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class TryCatch
    {
        public void TheCode()
        {
            try
            {
                Console.WriteLine("Before the error");

                ClassA.ProcessA();

                Console.WriteLine("After the error");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("There has been an exception");
                Console.WriteLine("This was the error: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("We got divide by zero exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("This was an unexpected exception");
            }

            Console.WriteLine("The end");
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
                //throw new Exception();
                //throw new NotImplementedException();
                //throw new DivideByZeroException();
                throw new FieldAccessException();
            }
        }

    }
}
