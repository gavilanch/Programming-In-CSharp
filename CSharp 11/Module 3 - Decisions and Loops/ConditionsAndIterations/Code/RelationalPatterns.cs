using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class RelationalPatterns
    {
        public void TheCode()
        {
            var temperature = 36;

            var message = temperature switch
            {
                37 => "You are healthy!",
                > 37 => "You have fever!",
                <= 36 => "You may be low on sugar",
            };

            Console.WriteLine(message);
        }
    }
}
