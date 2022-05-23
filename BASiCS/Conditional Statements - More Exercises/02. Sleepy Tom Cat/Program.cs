using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            int yearDays = 365;
            int playLimitPerYear = 30000;

            int yearPlayTime = (yearDays - freeDays) * 63 + freeDays * 127;
            double playTime = Math.Abs(yearPlayTime - playLimitPerYear);
            double playM = playTime % 60;
            double playH = Math.Floor(playTime / 60);

            if (yearPlayTime > playLimitPerYear)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{playH} hours and { playM} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{playH} hours and {playM} minutes less for play");
            }
        }
    }
}
