using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix_Garden_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gardenDimention = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int matrixRow = gardenDimention[0];
            int matrixCol = gardenDimention[1];

            int[,] matrix = SquareMatrix(matrixRow, matrixCol);
            List<string> savePositions = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                if (isInMatrix(matrix, tokens[0], tokens[1]))
                {
                    savePositions.Add(string.Join(" ", tokens));
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }                
            }
            savePositions.ForEach(flowersCoordinates =>
            {
                int[] rc = flowersCoordinates.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rc[0], col]++;
                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, rc[1]]++;
                }
                matrix[rc[0], rc[1]]--;
            });

            PrintMatrix(matrix);
        }


        public static int[,] SquareMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = 0;
                }
            }
            return matrix;
        }
        public static bool isInMatrix<T>(T[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
        public static void PrintMatrix<T>(T[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}