using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging.Code
{
    internal class FilteringExceptions
    {
        internal class CustomException : Exception
        {
            public CustomException(ErrorType errorType) : base("My custom error message")
            {
                ErrorType = errorType;
            }

            public CustomException(ErrorType errorType, string? message) : base(message)
            {
                ErrorType = errorType;
            }

            public ErrorType ErrorType { get; }
        }

        public enum ErrorType
        {
            ClientError,
            ServerError,
            ResourceNotFound
        }

        public void TheCode()
        {
            try
            {
                throw new CustomException(ErrorType.ResourceNotFound);
            }
            catch (CustomException ex) when (ex.ErrorType == ErrorType.ClientError)
            {
                Console.WriteLine("Client error");
            }
            catch (CustomException ex) when (ex.ErrorType == ErrorType.ServerError)
            {
                Console.WriteLine("Server error");
            }
            catch (CustomException ex) when (ex.ErrorType == ErrorType.ResourceNotFound)
            {
                Console.WriteLine("Resource not found error");
            }

            Console.WriteLine("The end");
        }
    }
}
