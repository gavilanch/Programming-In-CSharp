using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata
{
    internal class Person
    {
        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public string? Name { get; set; }
        [Range(minimum: 18, maximum: 130)]
        public int Age { get; set; }

        [Range(minimum: 1, maximum: 5)]
        public int AnotherNumber { get; set; }
    }
}
