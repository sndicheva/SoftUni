using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int ticket = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                ticket = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                ticket = 14;
            }
            else
            {
                ticket = 16;
            }
            Console.WriteLine(ticket);
        }
    }
}
