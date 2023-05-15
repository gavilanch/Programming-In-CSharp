using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExampleFelipe = AdditionalTopics.ExampleClaudia;

public class NamespaceAliasQualifier
{
    public void TheCode()
    {
        AdditionalTopics.ExampleFelipe.AliasExample.Print();
    }
}

namespace AdditionalTopics
{
    namespace ExampleFelipe
    {

        internal class AliasExample
        {
            public static string Name = "Felipe";

            public static void Print()
            {
                Console.WriteLine(ExampleFelipe::AliasExample.Name);
            }
        }
    }
}

namespace AdditionalTopics
{
    namespace ExampleClaudia
    {
        internal class AliasExample
        {
            public static string Name = "Claudia";

            public static void Print()
            {
                Console.WriteLine(ExampleFelipe.AliasExample.Name);
            }
        }
    }

}

namespace AdditionalTopics
{
    public class Test
    {
        private class System
        {

        }

        public void Print()
        {
            //System.Console.WriteLine("Hello");
            global::System.Console.WriteLine("Hello");
        }
    }
}
