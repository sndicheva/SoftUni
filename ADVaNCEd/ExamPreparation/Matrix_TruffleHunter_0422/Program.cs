using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Matrix_TruffleHunter_0422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] forest = new string[size, size];
            for (int row = 0; row < size; row++)
            {
                string[] inputRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for(int col = 0; col < size; col++)
                {
                    forest[row, col] = inputRow[col];
                }
            }
            Dictionary<char, int> collectedTruffles = new Dictionary<char, int>()
            {
                { 'B', 0 },
                { 'S', 0 },
                { 'W', 0 }
            };
            int wildBoarEaten = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop the hunt")
                {
                    break;
                }
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandInfo[0];
                int currRow = int.Parse(commandInfo[1]);
                int currCol = int.Parse(commandInfo[2]);
                if (action == "Collect")
                {
                    if (forest[currRow, currCol] == "B")
                    {
                        collectedTruffles['B']++;
                    }
                    else if (forest[currRow, currCol] == "S")
                    {
                        collectedTruffles['S']++;
                    }
                    else if (forest[currRow, currCol] == "W")
                    {
                        collectedTruffles['W']++;
                    }
                    forest[currRow, currCol] = "-";
                }
                else if(action == "Wild_Boar")
                {
                    string direction = commandInfo[3];
                    switch (direction)
                    {
                        case "up":
                            for (int row = currRow; row >=0; row-=2)
                            {
                                if (forest[row, currCol] != "-")
                                {
                                    wildBoarEaten++;
                                    forest[row, currCol] = "-";
                                }
                            }
                            break;
                        case "down":
                            for (int row = currRow; row < size; row += 2)
                            {
                                if (forest[row, currCol] != "-")
                                {
                                    wildBoarEaten++;
                                    forest[row, currCol] = "-";
                                }
                            }
                            break;
                        case "left":
                            for (int col = currCol; col >=0; col -= 2)
                            {
                                if (forest[currRow, col] != "-")
                                {
                                    wildBoarEaten++;
                                    forest[currRow, col] = "-";
                                }
                            }
                            break;
                        case "right":
                            for (int col = currCol; col < size; col += 2)
                            {
                                if (forest[currRow, col] != "-")
                                {
                                    wildBoarEaten++;
                                    forest[currRow, col] = "-";
                                }
                            }
                            break;
                    }
                }
            }
            Console.WriteLine($"Peter manages to harvest {collectedTruffles['B']} black, {collectedTruffles['S']} summer, and {collectedTruffles['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildBoarEaten} truffles.");
            
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(forest[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
