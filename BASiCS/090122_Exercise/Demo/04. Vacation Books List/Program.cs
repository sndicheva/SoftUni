using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // int - broj stranici na kniga
            // int - broj stranici za chas
            // int - broj dni za vsichki knigi
            int pagesBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForAllBooks = int.Parse(Console.ReadLine());

            // int obshto vreme za chetene na knigata
            int timePerBook = pagesBook / pagesPerHour;

            // int neobhodimo vreme na den
            int timePerDay = timePerBook / daysForAllBooks;

            Console.WriteLine(timePerDay);
        }
    }
}
