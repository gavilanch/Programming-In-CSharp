using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ.Code
{
    internal class WhatIsLINQ
    {
        internal void TheCode()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numbers2 = Enumerable.Range(1, 5).ToArray();

            // This is LINQ (Method syntax)
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            // Form 2: Query syntax
            var evenNumbers2 = (from n in numbers
                                where n % 2 == 0
                                select n).ToList();
        }
    }
}
