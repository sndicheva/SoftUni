using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());
            int counterPieces = 0;
            int countCake = widthCake * lengthCake;
            //int allPieces = widthCake * lengthCake;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                counterPieces += int.Parse(input);

                if (counterPieces > countCake)
                {
                    Console.WriteLine($"No more cake left! You need {counterPieces - countCake} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            
            if (countCake >= counterPieces)
            {
                Console.WriteLine($"{countCake- counterPieces} pieces are left.");
            }

        }
    }
}
