using System;

namespace P06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double area = GetRectangle(height, weight);
            Console.WriteLine(area);
        }

        static double GetRectangle(double height, double weight)
        {
            return height * weight;
        }
    }
}
