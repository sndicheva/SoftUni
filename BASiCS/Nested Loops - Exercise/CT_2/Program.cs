using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int availableSeats = 0;

            int studentCounter = 0;
            int standardCounter = 0;
            int kidsCounter = 0;
            string ticketType = string.Empty;

            double movieTickets = 0;
            while (movieName != "Finish")
            {
                availableSeats = int.Parse(Console.ReadLine());
                movieTickets = 0;
                for (int i = 0; i < availableSeats; i++)
                {
                    ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "standard")
                    {
                        standardCounter++;
                    }
                    else if (ticketType == "student")
                    {
                        studentCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsCounter++;
                    }
                    movieTickets++;

                }
                Console.WriteLine($"{movieName} - {movieTickets / availableSeats * 100:f2}% full.");
                movieName = Console.ReadLine();
            }
            double totalTickets = standardCounter + studentCounter + kidsCounter;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentCounter / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardCounter / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidsCounter / totalTickets * 100:f2}% kids tickets.");

        }
    }
}
