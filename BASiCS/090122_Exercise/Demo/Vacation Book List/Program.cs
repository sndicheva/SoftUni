using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForAllBooks = int.Parse(Console.ReadLine());

            int timePerBook = pagesBook / pagesPerHour;

            int timePerDay = timePerBook / daysForAllBooks;

            Console.WriteLine(timePerDay);
        }
    }
}
