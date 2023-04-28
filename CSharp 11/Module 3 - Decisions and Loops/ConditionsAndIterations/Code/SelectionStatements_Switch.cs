using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsAndIterations.Code
{
    internal class SelectionStatements_Switch
    {
        public void TheCode()
        {
            var place = 5;

            switch (place)
            {
                case 1:
                    Console.WriteLine("You are in first place!");
                    break;
                case 2:
                    Console.WriteLine("You are in second place!");
                    Console.WriteLine("Another line of code");
                    break;
                case 3:
                    Console.WriteLine("You can sell your bronze medal in a pawn shop!");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("You almost made it!");
                    break;
                default:
                    Console.WriteLine("Better luck next time!");
                    break;
            }
        }
    }
}
