using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double lice = Math.PI * Math.Pow(r , 2);
            double perimetar = 2 * Math.PI * r;

            //Math.Pow(r,2)


            Console.WriteLine($"{lice:f2}");
            Console.WriteLine($"{perimetar:f2}");
        }
    }
}
