using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            int volume = width * length * heigth;

            string input = Console.ReadLine();
            int movedCubes = 0;

            while (input != "Done")
            {
                movedCubes = int.Parse(input);
                
                if (movedCubes > volume)
                {
                    volume -= movedCubes;
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
                volume -= movedCubes;
                input = Console.ReadLine();
            }
            if (volume >= 0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }

        }
    }
}
