using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Claudia = AdditionalTopics.Examples.Claudia;
using Felipe = AdditionalTopics.Examples.Felipe;

namespace AdditionalTopics.Code
{
    internal class AliasesExample
    {
        public void TheCode()
        {
            var name = Claudia.AliasExample.Name;
            var felipesName = Felipe.AliasExample.Name;

            Console.WriteLine(name);
            Console.WriteLine(felipesName);
        }
    }
}

namespace AdditionalTopics.Examples.Felipe
{
    internal class AliasExample
    {
        public static string Name = "Felipe";
    }
}

namespace AdditionalTopics.Examples.Claudia
{
    internal class AliasExample
    {
        public static string Name = "Claudia";
    }
}
