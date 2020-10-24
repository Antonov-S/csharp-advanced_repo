using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            printPrincipalDiagonal(matrix, n);
        }

        static void printPrincipalDiagonal(int[,] mat, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    // Condition for principal diagonal
                    if (i == j)
                    {
                        sum += mat[i, j];
                    }
                }
            }

            Console.WriteLine(sum);
            
        }

        
    }
}
