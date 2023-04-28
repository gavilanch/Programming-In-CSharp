using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class ConditionalBooleanOperators
    {
        public void TheCode()
        {
            var num1 = 4;

            var isBetween5and10 = num1 > 5 && num1 < 10; // false && true => false

            // The && operator
            // true && true => true
            // true && false => false
            // false && true => false
            // false && false => false

            // The || operator
            // true || true => true
            // true || false => true
            // false || true => true
            // false || false => false

            var isNum14or5 = num1 == 4 || num1 == 5; // true || false => true

            //Console.WriteLine(isNum14or5);

            // Avoiding the null reference exception

            string? lastName = "gavilan";

            var isLastNameEqualToGavilan = lastName != null && lastName.ToUpper() == "GAVILAN";

            Console.WriteLine(isLastNameEqualToGavilan);
        }
    }
}
