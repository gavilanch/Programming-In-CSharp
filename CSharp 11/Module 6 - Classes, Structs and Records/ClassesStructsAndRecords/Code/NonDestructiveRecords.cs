using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal class NonDestructiveRecords
    {
        public void TheCode()
        {
            var company1 = new Company("Udemy", 2011);

            var company2 = company1 with { foundationYear = 2015 };

            Console.WriteLine("Company 1: " + company1);
            Console.WriteLine("Company 2: " + company2);

            Console.WriteLine("The end");
        }
    }
}
