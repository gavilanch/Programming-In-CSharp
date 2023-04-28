using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ
{
    internal class Person
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public bool IsSingle { get; set; }
        public DateTime DateJoinedTheCompany { get; set; }
        public List<string> PhoneNumbers = new List<string>();
        public int CompanyId { get; set; }

    }
}
