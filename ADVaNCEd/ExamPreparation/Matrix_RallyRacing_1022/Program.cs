using System;


namespace Matrix_RallyRacing_1022
{
    internal class Program
    {
        private static int size = int.Parse(Console.ReadLine());
        private static string racingCarNumber = Console.ReadLine();
        private static string[,] raceRoute = new string[size, size];
        private static int kilometers = 0;
        private static int carRow = 0;
        private static int carCol = 0;
        private static int tunnelRowOne = 0;
        private static int tunnelRowTwo = 0;
        private static int tunnelColOne = 0;
        private static int tunnelColTwo = 0;
        private static bool isFirstTunnelLocation = true;
        private static bool isHitTheFinish = false;

        static void Main(string[] args)
        {
            InputRaceRoute(size);

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
                if (isHitTheFinish) { break; }
            }
            raceRoute[carRow, carCol] = "C";

            if (isHitTheFinish)
            {
                Console.WriteLine($"Racing car {racingCarNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {racingCarNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {kilometers} km.");
            PrintPlayground(size);
        }

        private static void InputRaceRoute(int size)
        {
            for (int row = 0; row < size; row++)
            {
                string[] inputRow = Console.ReadLine().Split(" ");
                for (int col = 0; col < size; col++)
                {
                    raceRoute[row, col] = inputRow[col];
                    if (raceRoute[row, col] == "T")
                    {
                        if (isFirstTunnelLocation)
                        {
                            tunnelRowOne = row;
                            tunnelColOne = col;
                            isFirstTunnelLocation = false;
                        }
                        else
                        {
                            tunnelRowTwo = row;
                            tunnelColTwo = col;
                        }
                    }
                }
            }
        }
        private static void Move(int row, int col)
        {
            raceRoute[carRow, carCol] = ".";
            if (raceRoute[carRow + row, carCol + col] == "T")
            {
                raceRoute[carRow+row, carCol+col] = ".";
                if (carRow + row == tunnelRowOne && carCol + col == tunnelColOne)
                {
                    carRow = tunnelRowTwo;
                    carCol = tunnelColTwo;
                }
                else
                {
                    carRow = tunnelRowOne;
                    carCol = tunnelColOne;
                }
                raceRoute[carRow, carCol] = ".";
                kilometers += 30;
            }
            else if (raceRoute[carRow + row, carCol + col] == ".")
            {
                carRow += row;
                carCol += col;
                kilometers += 10;
            }
            else if (raceRoute[carRow + row, carCol + col] == "F")
            {
                
                carRow += row;
                carCol += col;
                kilometers += 10;
                isHitTheFinish = true;
            }

        }
        private static void PrintPlayground(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(raceRoute[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}