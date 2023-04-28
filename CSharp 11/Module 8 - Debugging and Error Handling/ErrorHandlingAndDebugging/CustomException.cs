using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAndDebugging
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
}
