using System;
using System.Linq;

namespace Printing_matrix_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing matrix
            static void PrintMatrix(int[,] matrix)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = row + col;
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }

            static int SumMatrix(int[,] matrix)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        sum += matrix[row, col];
                    }
                }

                return sum;
            }

            static int[,] ReadMatrix(int rows, int cols)
            {
                int[,] matrix = new int[rows, cols];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int[] rowData = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = rowData[col];
                    }
                }

                return matrix;
            }
        }


    }
}
