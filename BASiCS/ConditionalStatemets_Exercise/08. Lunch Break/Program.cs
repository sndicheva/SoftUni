using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //време за обедна почивка 8/8
            //1/8 за обяд
            //1/4 за отдих=2/8
            //общо 3/8 за обяд и отдих =сме заети
            //колко време можем да отделим за сериала

            // ако почивката е 80 мин
            // 8/8 - 3/8 = за сериала имаме 5/8 от обедната почивка =>50 мин (80/8*5)

            string seriesName = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchBreakTime = int.Parse(Console.ReadLine());

            double timeForSeries = lunchBreakTime * 5.0 / 8;
            //serial = 60, vreme 80
            //=> izvajdame ot vremeto za seriala/80 - prodaljitelnostta na seriala/60
            if (timeForSeries>=seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries-seriesTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes.");
            }



        }
    }
}
