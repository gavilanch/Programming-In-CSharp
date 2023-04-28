using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class TwoDimensionalArrays
    {
        public void TheCode()
        {
            int[,] matrix = new int[3, 2];

            int[,] matrix2 = new int[,]
            {
    {5, 6 },
    {7, 8 }
            };

            // The dimensions of the array with Rank

            Console.WriteLine($"My array has {matrix.Rank} dimensions");

            matrix[0, 0] = 1; // first row, first column
            matrix[0, 1] = 2; // first row, second column
            matrix[1, 0] = 3; // second row, first column
            matrix[1, 1] = 4; // second row, second column
            matrix[2, 0] = 5; // third row, first column
            matrix[2, 1] = 6; // third row, second colum

            var element = matrix[1, 0]; // 3

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
