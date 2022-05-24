using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPpl = int.Parse(Console.ReadLine());
            double taxEnter = double.Parse(Console.ReadLine());
            double taxSit = double.Parse(Console.ReadLine());
            double taxUmbr = double.Parse(Console.ReadLine());

            double countSit = Math.Ceiling(numPpl * 0.75);
            double sumUmbr = Math.Ceiling(numPpl/2) * taxUmbr;
            double sumEnter = numPpl * taxEnter;
            double sumSit = countSit * taxSit;
            double sumAll = sumUmbr + sumEnter + sumSit;

            Console.WriteLine($"{sumAll:f2} lv.");
        }
    }
}
