using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class SwitchExpressions
    {
        public void TheCode()
        {
            var place = 1;

            var message = place switch
            {
                1 => "You are in first place!",
                2 => "You are in second place!",
                3 => "You can sell your bronze medal in a pawn shop!",
                4 or 5 => "You almost made it!",
                _ => "Better luck next time!"
            };

            Console.WriteLine(message);
        }
    }
}
