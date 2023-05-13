using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class AttributesIntroduction
    {
        public void TheCode()
        {
            var person = new Person();

            person.Age = 15;
            person.AnotherNumber = 12;

            var validationErrors = ValidateObject(person);

            foreach (var validation in validationErrors)
            {
                Console.WriteLine($"- Property: {validation.Property}; Error: {validation.ErrorMessage}");
            }

            Console.WriteLine("The end");
        }

        bool ValidatePerson(Person p)
        {
            var type = p.GetType();
            var propertyAge = type.GetProperty("Age")!;

            if (propertyAge.IsDefined(typeof(RangeAttribute)))
            {
                var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(propertyAge, typeof(RangeAttribute))!;
                return p.Age >= (int)rangeAttribute.Minimum && p.Age <= (int)rangeAttribute.Maximum;
            }

            return true;
        }

        IEnumerable<ValidationError> ValidateObject(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties();

            var result = new List<ValidationError>();

            foreach (var property in properties)
            {
                if (property.IsDefined(typeof(RangeAttribute)))
                {
                    var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute))!;
                    var value = (int)property.GetValue(obj)!;
                    var minimum = (int)rangeAttribute.Minimum;
                    var maximum = (int)rangeAttribute.Maximum;
                    var isValid = value >= minimum && value <= maximum;
                    if (!isValid)
                    {
                        result.Add(new ValidationError
                        {
                            Property = property.Name,
                            ErrorMessage = $"The value should be between {minimum} and {maximum}"
                        });
                    }
                }
            }

            return result;
        }
    }
}
