using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections.Code
{
    internal class DictionariesIntroduction
    {
        public void TheCode()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["One"] = 1;
            dictionary["Two"] = 2;
            dictionary["Three"] = 3;

            Console.WriteLine(dictionary["Two"]);

            // Error: Key not found
            //Console.WriteLine(dictionary["Four"]);

            if (dictionary.ContainsKey("Four"))
            {
                Console.WriteLine(dictionary["Four"]);
            }
            else
            {
                Console.WriteLine("The key was not found");
            }

            dictionary.Remove("Two");

            // Error: Can't add the same key twice
            //dictionary.Add("One", 2);

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in dictionary.Values)
            {
                Console.WriteLine(value);
            }

            // Example 2: Classifying numbers

            var dictionaryEvenOdd = new Dictionary<string, List<int>>();
            dictionaryEvenOdd.Add("Even", new List<int>());
            dictionaryEvenOdd.Add("Odd", new List<int>());

            for (int i = 1; i < 10; i++)
            {
                var key = i % 2 == 0 ? "Even" : "Odd";
                dictionaryEvenOdd[key].Add(i);
            }

            foreach (var keyValuePair in dictionaryEvenOdd)
            {
                Console.WriteLine(keyValuePair.Key);

                foreach (var value in keyValuePair.Value)
                {
                    Console.WriteLine($"- {value}");
                }
                Console.WriteLine();
            }
        }
    }
}
