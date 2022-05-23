using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //лице на стените :
            double door = 1.2 * 2;
            double frontAndBackWalls = 2 * x * x - door;
            double window = 1.5 * 1.5;
            double sideWalls = 2 * (x * y - window);
            double roofTriangle = 2 * (x * h) * 0.5;
            double roofSide = 2 * (y * x);
           
            //изчисление на боята:
            double greenPaintN = (frontAndBackWalls + sideWalls) / 3.4;
            double redPaintN = (roofTriangle + roofSide) / 4.3;
           
            //извеждане на екрана:
            Console.WriteLine($"{greenPaintN:f2}");
            Console.WriteLine($"{redPaintN:f2}");
            
        }
    }
}
