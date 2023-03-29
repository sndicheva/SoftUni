using System;
using System.Globalization;
using System.Linq;

namespace Matrix_Selling_1220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string inputRows = Console.ReadLine();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = inputRows[cols].ToString();
                }
            }

            int startRow = 0, startCol = 0;
            int firstPilarRow = 0, firstPilarCol = 0, secondPilarRow = 0, secondPilarCol = 0;
            bool isFirst = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == "S")
                    {
                        startRow = rows;
                        startCol = cols;
                    }
                    if (matrix[rows, cols] == "O" && !isFirst)
                    {
                        firstPilarRow = rows;
                        firstPilarCol = cols;
                        isFirst = true;
                    }
                    if (matrix[rows, cols] == "O" && isFirst)
                    {
                        secondPilarRow = rows;
                        secondPilarCol = cols;
                    }
                }
            }
            const int moneyNeeded = 50;
            int money = 0;
            //if (char.IsDigit(matrix[rows, cols]))

            while (IsInMatrix(matrix, startRow, startCol) && money < moneyNeeded)
            {
                matrix[startRow, startCol] = "-";
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        if (IsInMatrix(matrix, startRow - 1, startCol))
                        {
                            startRow--;
                            if (matrix[startRow, startCol] == "O")
                            {
                                matrix[firstPilarRow, firstPilarCol] = "-";
                                startRow = secondPilarRow;
                                startCol = secondPilarCol;
                                matrix[secondPilarRow, secondPilarCol] = "S";
                            }
                            else if (char.IsDigit(char.Parse(matrix[startRow, startCol])))
                            {
                                money += int.Parse(matrix[startRow, startCol]);
                                matrix[startRow, startCol] = "S";
                            }
                            else
                            {
                                matrix[startRow, startCol] = "S";
                            }
                        }
                        else { PrintVoid(matrix, money); return; }
                        break;
                    case "down":
                        if (IsInMatrix(matrix, startRow + 1, startCol))
                        {
                            startRow++;
                            if (matrix[startRow, startCol] == "O")
                            {
                                matrix[firstPilarRow, firstPilarCol] = "-";
                                startRow = secondPilarRow;
                                startCol = secondPilarCol;
                                matrix[secondPilarRow, secondPilarCol] = "S";
                            }
                            else if (char.IsDigit(char.Parse(matrix[startRow, startCol])))
                            {
                                money += int.Parse(matrix[startRow, startCol]);
                                matrix[startRow, startCol] = "S";
                            }
                            else
                            {
                                matrix[startRow, startCol] = "S";
                            }
                        }
                        else { PrintVoid(matrix, money);  return; }
                        break;
                    case "left":
                        if (IsInMatrix(matrix, startRow, startCol - 1))
                        {
                            startCol--;
                            if (matrix[startRow, startCol] == "0")
                            {
                                matrix[firstPilarRow, firstPilarCol] = "-";
                                startRow = secondPilarRow;
                                startCol = secondPilarCol;
                                matrix[secondPilarRow, secondPilarCol] = "S";
                            }
                            else if (char.IsDigit(char.Parse(matrix[startRow, startCol])))
                            {
                                money += int.Parse(matrix[startRow, startCol]);
                                matrix[startRow, startCol] = "S";
                            }
                            else
                            {
                                matrix[startRow, startCol] = "S";
                            }
                        }
                        else { PrintVoid(matrix, money); return; }
                        break;
                    case "right":
                        if (IsInMatrix(matrix, startRow, startCol + 1))
                        {
                            startCol++;
                            if (matrix[startRow, startCol] == "O")
                            {
                                matrix[firstPilarRow, firstPilarCol] = "-";
                                startRow = secondPilarRow;
                                startCol = secondPilarCol;
                                matrix[secondPilarRow, secondPilarCol] = "S";
                            }
                            else if (char.IsDigit(char.Parse(matrix[startRow, startCol])))
                            {
                                money += int.Parse(matrix[startRow, startCol]);
                                matrix[startRow, startCol] = "S";
                            }
                            else
                            {
                                matrix[startRow, startCol] = "S";
                            }
                        }
                        else { PrintVoid(matrix, money); return; }
                        break;
                }
            }
            if (money>=moneyNeeded)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
                Console.WriteLine($"Money: {money}");
            }
            PrintMatrix(matrix);
        }

        public static void PrintVoid(string[,] matrix, int money)
        {
            Console.WriteLine("Bad news, you are out of the bakery.");
            Console.WriteLine($"Money: {money}");
            PrintMatrix(matrix);
        }

        public static bool IsInMatrix<T>(T[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        public static void PrintMatrix<T>(T[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
