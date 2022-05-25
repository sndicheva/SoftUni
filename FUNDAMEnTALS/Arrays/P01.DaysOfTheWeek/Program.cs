using System;

namespace P01.DaysOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek = new string[]
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
                };

            if (dayNumber >= 1 && dayNumber <= daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
