using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadium = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;
            

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        fansA++;
                        break;
                    case "B":
                        fansB++;
                        break;
                    case "V":
                        fansV++;
                        break;
                    default:
                        fansG++;
                        break;
                }

            }
            double percentFans = fansA + fansB + fansG + fansV;
            Console.WriteLine($"{fansA / fans * 100:f2}%");
            Console.WriteLine($"{fansB / fans * 100:f2}%");
            Console.WriteLine($"{fansV / fans * 100:f2}%");
            Console.WriteLine($"{fansG / fans * 100:f2}%");
            Console.WriteLine($"{percentFans / stadium * 100:f2}%");
        }
    }
}
