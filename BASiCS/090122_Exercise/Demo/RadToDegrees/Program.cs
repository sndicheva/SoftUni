using System;

namespace RadToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем radians
            double radians = double.Parse(Console.ReadLine());

            //преобразуваме radians to degrees => degrees = radians * 180 / Math.PI
            double degrees = radians * 180 / Math.PI;

            //отпечатваме резултата (degrees)
            Console.WriteLine(degrees);
        }
    }
}
