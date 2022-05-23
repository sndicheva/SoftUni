using System;

namespace jhlkjhk
{
    class Program
    {
        static void Main(string[] args)
        {
            double WorldRecord = double.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            // s/15 = v * t12.5
            double delay = Math.Floor(distanceM / 15)*12.5;

            //delay = Math.Floor(delay);

            double totaltime = (distanceM * timeForOneMeter) + delay;

            double under = 0;

            if (totaltime < WorldRecord)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {totaltime:F2} seconds.");
            }
            else
            {
                under = totaltime - WorldRecord;
                Console.WriteLine($"No, he failed! He was {under:F2} seconds slower.");
            }
        }
    }
}
