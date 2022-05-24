using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double earnAim = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int coctailCount = 0;
            double orderedDaily = 0;
            double ordered = 0;

            while (input != "Party!")
            {
                coctailCount = int.Parse(Console.ReadLine());
                int coctailPrice = input.Length;
                ordered = coctailCount * coctailPrice;
                if (ordered % 2 != 0)
                {
                    ordered -= ordered * 0.25;
                }
                orderedDaily += ordered;
                if (orderedDaily >= earnAim)
                {
                    break;
                }               
                    input = Console.ReadLine();  
            }
            if (orderedDaily<earnAim)
            {
                Console.WriteLine($"We need {earnAim-orderedDaily:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
                Console.WriteLine($"Club income - {orderedDaily:f2} leva.");
        }
    }
}
