using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class Indexes
    {
        public void TheCode()
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            var secondVowel = vowels[1];

            Index lastElement = ^1;
            var lastVowel = vowels[lastElement]; // u

            var secondLastVowel = vowels[^2]; // o
        }
    }
}
