using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class CustomExceptionCode
    {
        public void TheCode()
        {
            throw new CustomException("Another custom error message");

            Console.WriteLine("The end");
        }

        internal class CustomException : Exception
        {
            public CustomException() : base("My custom error message")
            {

            }

            public CustomException(string? message) : base(message)
            {

            }
        }
    }
}
