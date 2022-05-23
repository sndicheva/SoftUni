using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double hC = h - 1;
            
            double c = (w - w % 1.2) / 1.2;
            double r = (hC - hC % 0.7) / 0.7;
            
            
            double workAreas = (r * c) - 3;


            Console.WriteLine(workAreas);
        }
    }
}
