using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords.Code
{
    internal static class StringExtensions
    {
        internal static int CountWords(this string? s, int defaultValue = -1)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return defaultValue;
            }

            // s = "C# is cool" => ["C#", "is", "cool"] => 3 words
            var separators = new string[] { " ", Environment.NewLine };
            var words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    internal class ExtensionMethods
    {
        public void TheCode()
        {
            var message = @"This is a message,

from: Felipe";

            // With extension method
            var amountOfWords = message.CountWords(0);

            // Without the extension method
            var amountOfWords2 = StringExtensions.CountWords(message);

            Console.WriteLine($"Amount of words: {amountOfWords}");

            // We can pass parameters to extension methods
            message = null;
            var amountOfWords3 = message.CountWords(0);
            Console.WriteLine($"Amount of words: {amountOfWords}");
        }   
    }
}
