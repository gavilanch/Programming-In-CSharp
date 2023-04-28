using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class Ranges
    {
        public void TheCode()
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Range firstTwoElements = ..2;
            var firstTwoVowels = vowels[firstTwoElements]; // 0, 1 
            var firstThreeVowels = vowels[..3]; // 0, 1, 2

            var lastTwoVowels = vowels[^2..]; // ^2, ^1
            var lastTwoVowels2 = vowels[3..]; // 3, 4

            Range ignoreFirstAndLast = 1..^1; // 1,2,3
            var allButFirstAndLast = vowels[ignoreFirstAndLast];

            foreach (var vowel in lastTwoVowels2)
            {
                Console.WriteLine(vowel);
            }
        }
    }
}
