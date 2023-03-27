using System;

namespace Matrix_Snake_0620
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] snakeTerritory = new char[size, size];

            (int snakeRow, int snakeCol) = (0, 0);

            for (int row = 0; row < size; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    snakeTerritory[row, col] = rowInput[col];
                    if (snakeTerritory[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            (int firstBurrowRow, int firstBurrowCol, int secondBurrowRow, int secondBurrowCol) = GetBurrowPositions(snakeTerritory);

            int foodQuantity = 0;

            while (foodQuantity < 10)
            {
                string command = Console.ReadLine();

                snakeTerritory[snakeRow, snakeCol] = '.';

                switch (command)
                {
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "right":
                        snakeCol++;
                        break;
                }
                if (snakeRow < 0 || snakeRow >= snakeTerritory.GetLength(0) || snakeCol < 0 || snakeCol >= snakeTerritory.GetLength(1))
                {
                    break;
                }

                if (snakeTerritory[snakeRow, snakeCol] == '*')
                {
                    foodQuantity++;
                }
                else if (snakeTerritory[snakeRow, snakeCol] == 'B')
                {
                    snakeTerritory[snakeRow, snakeCol] = '.';
                    if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                    {
                        snakeRow = secondBurrowRow;
                        snakeCol = secondBurrowCol;
                    }
                    else
                    {
                        snakeRow = firstBurrowRow;
                        snakeCol = firstBurrowCol;
                    }
                }

                snakeTerritory[snakeRow, snakeCol] = 'S';
            }

            if (foodQuantity == 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
            Console.WriteLine($"Food eaten: {foodQuantity}");

            PrintMatrix(snakeTerritory);
        }

        private static (int, int, int, int) GetBurrowPositions(char[,] snakeTerritory)
        {

            bool isFirstBurrow = true;
            int firstBurrowRow = 0;
            int firstBurrowCol = 0;

            for (int row = 0; row < snakeTerritory.GetLength(0); row++)
            {
                for (int col = 0; col < snakeTerritory.GetLength(1); col++)
                {
                    if (snakeTerritory[row, col] == 'B')
                    {
                        if (isFirstBurrow)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                            isFirstBurrow = false;
                        }
                        else
                        {
                            return (firstBurrowRow, firstBurrowCol, row, col);
                        }
                    }
                }
            }
            return (0, 0, 0, 0);
        }

        private static void PrintMatrix(char[,] snakeTerritory)
        {
            for (int row = 0; row < snakeTerritory.GetLength(0); row++)
            {
                for (int col = 0; col < snakeTerritory.GetLength(1); col++)
                {
                    Console.Write(snakeTerritory[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
