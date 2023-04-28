using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class ArraysIntroduction
    {
        public void TheCode()
        {
            char[] vowels = new char[5];

            vowels[0] = 'a'; // First element
            vowels[1] = 'e'; // Second element
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            var vowels2 = new char[] { 'a', 'e', 'i', 'o', 'u' };

            // Arrays are reference types
            vowels2 = null;

            var secondElement = vowels[1];

            //Console.WriteLine(secondElement);

            // Trying to read an nonexistent element

            //var magicalVowel = vowels[5];

            foreach (var vowel in vowels)
            {
                Console.WriteLine(vowel);
            }

            var length = vowels.Length; // 5
        }
    }
}
