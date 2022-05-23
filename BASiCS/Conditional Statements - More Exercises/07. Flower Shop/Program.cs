using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int zumbul = int.Parse(Console.ReadLine());
            int rosse = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double order = magnolia * 3.25 + zumbul * 4 + rosse * 3.5 + cactus * 8;
            double tax = order * 0.05;
            double win = order - tax;

            if (win >= gift)
            {
                Console.WriteLine($"She is left with {Math.Floor(win - gift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift - win)} leva.");
            }
        }
    }
}
