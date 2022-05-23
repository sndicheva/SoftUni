using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            
            double p1 = 0;//до 5 човека – изкачват Мусала
            double p2 = 0;//от 6 до 12 човека – изкачват Монблан
            double p3 = 0;//от 13 до 25 човека – изкачват Килиманджаро
            double p4 = 0; //от 26 до 40 човека –  изкачват К2
            double p5 = 0; //от 41 или повече човека – изкачват Еверест

            for (int i = 1; i <= n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (p <= 5)
                {
                    p1 += p;// p1 = p1 + p;
                }
                else if (p >= 6 && p <= 12)
                {
                    p2 += p;
                }
                else if (p >= 13 && p <= 25)
                {
                    p3 += p;
                }
                else if (p >= 26 && p <= 40)
                {
                    p4 += p;
                }
                else
                {
                    p5 += p;
                }
            }
            double all = p1 + p2 + p3 + p4 + p5;

            //p1 = p1 * 100 / all;
            //p2 = p2 * 100 / all;
            p3 = p3 * 100 / all;
            p4 = p4 * 100 / all;
            p5 = p5 * 100 / all;

            Console.WriteLine($"{p1 * 100 / all:f2}%");
            Console.WriteLine($"{p2 / all * 100:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);
            //Console.WriteLine(p4);
            //Console.WriteLine(p5);

        }
    }
}
