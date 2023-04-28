using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Code
{
    internal class SolvingThePrintingMatrixProblem
    {
        public void TheCode()
        {
            int[,] matrix = new int[,]
                            {
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            int[,] matrix2 = new int[,]
                            {
                                {5, 6 },
                                {7, 8 }
                            };

            PrintTwoDimensionalArray(matrix);
            Console.WriteLine("--");
            PrintTwoDimensionalArray(matrix2);
        }

        void PrintTwoDimensionalArray(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column]);
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }
}
