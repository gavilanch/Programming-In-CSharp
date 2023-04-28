using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
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
}
