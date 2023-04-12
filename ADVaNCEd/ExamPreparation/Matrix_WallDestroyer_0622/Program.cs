using System;

namespace Matrix_WallDestroyer_0622
{
    internal class Program
    {
        private static int size = int.Parse(Console.ReadLine());
        private static char[,] wall = new char[size, size];
        private static int vankoRow = 0;
        private static int vankoCol = 0;
        private static int countOfHoles = 1;
        private static int countOfRods = 0;
        private static bool isAlive = true;
        static void Main(string[] args)
        {
            InputWall(size);            

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                switch (command)
                {
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                    case "left":
                        Move(0, -1);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                }
                if (!isAlive) { break; }
            }
            if (isAlive)
            {
                Console.WriteLine($"Vanko managed to make {countOfHoles} hole(s) and he hit only {countOfRods} rod(s).");
            }
            PrintMatrix(size);
        }

        private static void InputWall(int size)
        {
            for (int row = 0; row < size; row++)
            {
                string inputRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    wall[row, col] = inputRow[col];
                    if (wall[row, col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }
        }
        private static bool isInside(int row, int col)
        {
            return (row >= 0 && row < size && col >= 0 && col < size);
        }
        private static void Move(int row, int col)
        {
            if (isInside(vankoRow + row, vankoCol + col))
            {
                if (wall[vankoRow + row, vankoCol + col] == 'C')
                {
                    wall[vankoRow, vankoCol] = '*';
                    vankoRow += row;
                    vankoCol += col;
                    countOfHoles++;
                    wall[vankoRow, vankoCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                    isAlive = false;
                }
                else if (wall[vankoRow + row, vankoCol + col] == 'R')
                {
                    countOfRods++;
                    Console.WriteLine("Vanko hit a rod!");
                }
                else if (wall[vankoRow + row, vankoCol + col] == '-')
                {
                    wall[vankoRow, vankoCol] = '*';
                    vankoRow += row;
                    vankoCol += col;
                    wall[vankoRow, vankoCol] = 'V';
                    countOfHoles++;
                }
                else if (wall[vankoRow + row, vankoCol + col] == '*')
                {
                    wall[vankoRow, vankoCol] = '*';
                    vankoRow += row;
                    vankoCol += col;
                    Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                    wall[vankoRow, vankoCol] = 'V';
                }
            }
        }
        private static void PrintMatrix(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(wall[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
