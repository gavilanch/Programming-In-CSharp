using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class MatrixUtilities
    {
        public static double[,] InitializeMatrix(int rows, int columns)
        {
            double[,] matrix = new double[rows, columns];

            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(100);
                }
            }
            return matrix;
        }


        public static double[,] MultiplyMatricesSequentally(double[,] matA, double[,] matB)
        {
            int matARows = matA.GetLength(0);
            int matAColumns = matA.GetLength(1);
            int matBColumns = matB.GetLength(1);
            var result = new double[matARows, matBColumns];

            for (int i = 0; i < matARows; i++)
            {
                for (int j = 0; j < matBColumns; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matAColumns; k++)
                    {
                        temp += matA[i, k] * matB[k, j];
                    }
                    result[i, j] += temp;
                }
            }

            return result;
        }

        public static double[,] MultiplyMatricesInParallel(double[,] matA, double[,] matB)
        {
            int matARows = matA.GetLength(0);
            int matAColumns = matA.GetLength(1);
            int matBColumns = matB.GetLength(1);
            var result = new double[matARows, matBColumns];

            Parallel.For(0, matARows, i =>
            {
                {
                    for (int j = 0; j < matBColumns; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < matAColumns; k++)
                        {
                            temp += matA[i, k] * matB[k, j];
                        }
                        result[i, j] += temp;
                    }
                }
            });

            return result;
        }
    }
}
