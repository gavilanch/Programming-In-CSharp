using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class NonNullableReferenceTypes
    {
        public void TheCode()
        {
            int? age = null; // error
            string? firstName = null; 

            Console.WriteLine(firstName.ToUpper()); // This throws an exception (error)
        }
    }
}
