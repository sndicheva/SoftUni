using System;

namespace vremeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            // sunny, cloudy, rainy
            if (weather == "sunny")
            {
                Console.WriteLine("Go for a walk!");
            }
            else if (weather == "cloudy")
            {
                Console.WriteLine("Take an umbrela!");
            }
            else if (weather == "rainy")
            {
                Console.WriteLine("Stay at home!");
            }

        }
    }
}
