using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double tok = 0;
            double water = 0;
            double internet = 0;
            double others = 0;
            //double montly = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                tok += electricity;
                water += 20;
                internet += 15;                
                others += electricity + 20 + 15+(electricity + 20 + 15) * 0.2;
            }
            double average = (tok + water + internet + others) / months;
            Console.WriteLine($"Electricity: {tok:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
