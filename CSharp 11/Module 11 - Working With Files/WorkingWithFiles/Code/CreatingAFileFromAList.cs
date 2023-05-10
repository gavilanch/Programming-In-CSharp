using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Code
{
    internal class CreatingAFileFromAList
    {
        public void TheCode()
        {
            var route = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\people.txt";

            var people = new List<Person>
{
    new Person(){Id = 1, Name = "Felipe Gavilán", Salary = 25m},
    new Person(){Id = 2, Name = "Claudia Rodríguez", Salary = 155m},
    new Person(){Id = 3, Name = "Roberto Gonzalez", Salary = 42m},
    new Person(){Id = 4, Name = "Mariana Reyes", Salary = 39m},
    new Person(){Id = 5, Name = "Arturo Aristy", Salary = 50m},
};

            var stringBuilder = new StringBuilder();

            foreach (var person in people)
            {
                stringBuilder.AppendLine($"{person.Id.ToString().PadLeft(10, '0')}|{person.Name.PadLeft(75)}|{person.Salary.ToString("N").Replace(".", "").PadLeft(10, '0')}");
            }

            using (var sw = new StreamWriter(route, append: false))
            {
                sw.Write(stringBuilder.ToString());
            }
        }
    }
}
