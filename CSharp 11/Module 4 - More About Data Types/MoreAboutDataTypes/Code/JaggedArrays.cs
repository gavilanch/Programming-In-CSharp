using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class JaggedArrays
    {
        public void TheCode()
        {
            int[][] jaggedArray =
            {
                new int[]{1,2},
                new int[]{3, 4, 5},
                new int[]{6},
                new int[]{7,8}
            };

            var secondArray = jaggedArray[1]; // [3, 4, 5]

            foreach (var array in jaggedArray)
            {
                foreach (var item in array)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
