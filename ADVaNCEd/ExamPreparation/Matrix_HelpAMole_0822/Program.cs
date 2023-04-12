using System;

namespace Matrix_HelpAMole_0822
{
    internal class Program
    {
        private static int size = int.Parse(Console.ReadLine());
        private static string[,] playground = new string[size, size];
        private static int molePoints = 0;
        private static int moleRow = 0;
        private static int moleCol = 0;
        private static int specialRowOne = 0;
        private static int specialRowTwo = 0;
        private static int specialColOne = 0;
        private static int specialColTwo = 0;
        private static bool isFirstSpecialLocation = true;
        static void Main(string[] args)
        {
            InputPlayground(size);

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
                if (molePoints >= 25)
                {
                    break;
                }
            }
            if(molePoints >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");                
                Console.WriteLine($"The Mole managed to survive with a total of {molePoints} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {molePoints} points.");
            }
            PrintPlayground(size);
        }



        private static void InputPlayground(int size)
        {
            for (int row = 0; row < size; row++)
            {
                string inputRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    playground[row, col] = inputRow[col].ToString();
                    if (playground[row, col] == "M")
                    {
                        moleRow = row;
                        moleCol = col;
                    }
                    else if (playground[row, col] == "S")
                    {
                        if (isFirstSpecialLocation)
                        {
                            specialRowOne = row;
                            specialColOne = col;
                            isFirstSpecialLocation = false;
                        }
                        else
                        {
                            specialRowTwo = row;
                            specialColTwo = col;
                        }
                    }
                }
            }
        }
        private static bool IsInThePlayground(int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
        private static void Move(int row, int col)
        {
            if (IsInThePlayground(moleRow + row, moleCol + col))
            {
                if (playground[moleRow + row, moleCol + col] == "S")
                {
                    if (moleRow + row == specialRowOne && moleCol + col == specialColOne)
                    {
                        playground[moleRow, moleCol] = "-";
                        playground[moleRow + row, moleCol + col] = "-";
                        moleRow = specialRowTwo;
                        moleCol = specialColTwo;
                        playground[moleRow, moleCol] = "M";
                    }
                    else
                    {
                        playground[moleRow, moleCol] = "-";
                        playground[moleRow + row, moleCol + col] = "-";
                        moleRow = specialRowOne;
                        moleCol = specialColOne;
                        playground[moleRow, moleCol] = "M";
                    }
                    molePoints -= 3;

                    if (molePoints < 0)
                    {
                        molePoints = 0;
                    }
                }
                else if (char.IsDigit(char.Parse(playground[moleRow + row, moleCol + col])))
                {                    
                    molePoints += int.Parse(playground[moleRow + row, moleCol + col]);
                    playground[moleRow, moleCol] = "-";
                    moleRow += row;
                    moleCol += col;
                    playground[moleRow, moleCol] = "M";                    
                }
                else
                {
                    playground[moleRow, moleCol] = "-";
                    moleRow += row;
                    moleCol += col;
                    playground[moleRow, moleCol] = "M";
                }
            }
            else
            {
                Console.WriteLine("Don't try to escape the playing field!");
            }
        }
        private static void PrintPlayground(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(playground[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
