using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Code
{
    internal class ParallelForSpeed_MultiplyingMatrices
    {
        public async Task TheCode(PictureBox loadingGif)
        {
            loadingGif.Visible = true;

            int columnsMatA = 1080;
            int rowsMatA = 1000;
            int columnsB = 750;

            var matA = MatrixUtilities.InitializeMatrix(rowsMatA, columnsMatA);
            var matB = MatrixUtilities.InitializeMatrix(columnsMatA, columnsB);

            Console.WriteLine("Executing the sequential version");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await Task.Run(() =>
            {
                MatrixUtilities.MultiplyMatricesSequentally(matA, matB);
            });

            stopwatch.Stop();
            Console.WriteLine($"Duration in seconds sequential algorithm: {stopwatch.ElapsedMilliseconds / 1000.0}");
            stopwatch.Reset();

            Console.WriteLine("Executing the parallel version");
            stopwatch.Start();
            await Task.Run(() =>
            {
                MatrixUtilities.MultiplyMatricesInParallel(matA, matB);
            });
            stopwatch.Stop();
            Console.WriteLine($"Duration in seconds parallel algorithm: {stopwatch.ElapsedMilliseconds / 1000.0}");

            loadingGif.Visible = false;
        }

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
}
