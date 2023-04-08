using System;
using System.Linq;

namespace Matrix_TruffleHUnter_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = InputField(size);

            int blackTrCount = 0;
            int summerTrCount = 0;
            int whiteTrCount = 0;
            int eatedTrCount = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Stop")
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (command[0] == "Collect")
                {
                    if (row >= 0 && row < size && col >= 0 && col < size && field[row, col] != '-')
                    {
                        CollectTr(field, row, col, ref blackTrCount, ref summerTrCount, ref whiteTrCount);
                    }
                }
                else if (command[0] == "Wild_Boar")
                {
                    string direction = command[3];
                    switch (direction)
                    {
                        case "up":
                            for (int i = row; i >= 0; i -= 2)
                            {
                                eatedTrCount = EatTr(field, eatedTrCount, i, col);
                            }
                            break;
                        case "down":
                            for (int i = row; i < size; i += 2)
                            {
                                eatedTrCount = EatTr(field, eatedTrCount, i, col);
                            }
                            break;
                        case "left":
                            for (int i = col; i >= 0; i -= 2)
                            {
                                eatedTrCount = EatTr(field, eatedTrCount, row, i);
                            }
                            break;
                        case "right":
                            for (int i = col; i < size; i += 2)
                            {
                                eatedTrCount = EatTr(field, eatedTrCount, row, i);
                            }
                            break;
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTrCount} black, {summerTrCount} summer, and {whiteTrCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatedTrCount} truffles.");

            PrintField(field);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static char[,] InputField(int size)
        {
            char[,] field = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] rowInput = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowInput[col];
                }
            }

            return field;
        }
        static void CollectTr(char[,] field, int row, int col, ref int blackTrCount, ref int summerTrCount, ref int whiteTrCount)
        {
            if (field[row, col] == 'B')
            {
                blackTrCount++;
            }
            else if (field[row, col] == 'S')
            {
                summerTrCount++;
            }
            else if (field[row, col] == 'W')
            {
                whiteTrCount++;
            }

            field[row, col] = '-';
        }
        static int EatTr(char[,] field, int eatedTrCount, int row, int col)
        {
            if (field[row, col] != '-')
            {
                eatedTrCount++;
                field[row, col] = '-';
            }

            return eatedTrCount;
        }
    }
}
