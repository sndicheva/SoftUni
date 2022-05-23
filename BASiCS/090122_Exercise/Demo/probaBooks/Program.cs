using System;

namespace probaBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int numbersDays = int.Parse(Console.ReadLine());

            int readingOfHours = numberPages / pages;

            int hoursOfDays = readingOfHours / numbersDays;


            Console.WriteLine(hoursOfDays);
        }
    }
}
