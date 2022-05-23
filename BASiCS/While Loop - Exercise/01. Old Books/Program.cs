using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            //запазваме любимата книга на Ани
            string favoriteBook = Console.ReadLine();

            int count = 0; // брояч на неуспешните опити да откием книгата 

            string input = Console.ReadLine(); // книгата която гледаме в момента

            //създаваме цикъл в който всеки път ще четем заглавието на нова книга
            // => докато не минем през всички книги (докато не получим текста "No More Books")
            // => докато не намерим любимата книга
            while (input != "No More Books")
            {
                if (input == favoriteBook)
                {
                    //*Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }

                count++;
                input = Console.ReadLine();
            }

            // Ако сме я намерили: 	"You checked {брой} books and found it."
            if (input == favoriteBook)//*
            {//*
                Console.WriteLine($"You checked {count} books and found it.");//*
            }//*

            //Ако не сме я намерили: 
            //	"The book you search is not here!"
            //  "You checked {брой} books."
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
