using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class TernaryConditionalOperator
    {
        public void TheCode()
        {
            bool userIsLoggedIn = false;

            // var myVariable = boolean-expression ? value-if-true : value-if-false;
            string welcomeMessage = userIsLoggedIn ? "Glad you're back!" : "Log in to start";

            //if (userIsLoggedIn)
            //{
            //    welcomeMessage = "Glad you're back!";
            //}
            //else
            //{
            //    welcomeMessage = "Log in to start";
            //}

            Console.WriteLine(welcomeMessage);
        }
    }
}
