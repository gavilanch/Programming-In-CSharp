using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata
{
    internal class ValidationError
    {
        public string Property { get; set; } = null!;
        public string ErrorMessage { get; set; } = null!;
    }
}
