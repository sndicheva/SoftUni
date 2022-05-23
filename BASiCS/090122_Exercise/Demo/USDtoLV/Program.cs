using System;

namespace USDtoLV
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем USD
            double usd = double.Parse(Console.ReadLine());

            //preobrazuwame бгн=usd*1,79549;
            double bgn = usd * 1.79549;

            //изписваме на конзолата bgn
            Console.WriteLine(bgn);

        }
    }
}
