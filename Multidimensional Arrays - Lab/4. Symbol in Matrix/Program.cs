using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());
            bool isFound = false;
            int rowFound = 0;
            int colFound = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentSymbol = matrix[row, col];
                    if (currentSymbol == symbolToFind)
                    {
                        isFound = true;
                        rowFound = row;
                        colFound = col;
                        break;
                    }
                    
                }
            }

            if (isFound)
            {
                Console.WriteLine($"({rowFound}, {colFound})");
            }
            else
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }


        }
    }
}
