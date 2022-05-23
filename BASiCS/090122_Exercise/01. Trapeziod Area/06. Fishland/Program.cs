using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPr = double.Parse(Console.ReadLine());
            double cacaPr = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double palamudPr = skumriaPr + skumriaPr * 60 / 100;
            double safridPr = cacaPr + cacaPr * 80 / 100;
            //double midiPr = 7.50;

            double smetka = palamudKg * palamudPr + safridKg * safridPr + midiKg * 7.50;

            Console.WriteLine($"{smetka:f2}");

        }
    }
}
