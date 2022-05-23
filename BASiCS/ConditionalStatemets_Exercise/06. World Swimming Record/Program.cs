using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //входни данни
            double record = double.Parse(Console.ReadLine()); //секунди
            double distance = double.Parse(Console.ReadLine()); //метри
            double secPerMeter = double.Parse(Console.ReadLine()); //секудни за 1 метър

            double time = distance * secPerMeter;
            double speedWR = Math.Floor(distance / 15) * 12.5;
            double speedIvan = time + speedWR;
            if (speedIvan < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {speedIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - speedIvan):f2} seconds slower.");
            }
        }
    }
}
