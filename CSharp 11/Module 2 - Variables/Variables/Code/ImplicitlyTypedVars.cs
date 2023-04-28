using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Code
{
    internal class ImplicitlyTypedVars
    {
        public void TheCode()
        {
            var felipesAge = 999;
            var lastName = "Gavilán";
            var now = DateTime.Now;

            int age;
            // var age; // error: Have to initialize the variable

            age = 8;

        }
    }
}
