using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodDay = double.Parse(Console.ReadLine());
            double catFoodDay = double.Parse(Console.ReadLine());
            double turtleFoodDay = double.Parse(Console.ReadLine());

            double foodNeed = days * (dogFoodDay + catFoodDay + turtleFoodDay / 1000);
            //double catFN = days * catFoodDay;// 2
            //double dogFN = days * dogFoodDay;//2
            //double turtleFN = days * (turtleFoodDay / 1000);//2*1.2 = 2.4
            //double foodNeed = catFN + dogFN + turtleFN; // 2+2+2.4=6.4


            if (foodNeed <= food)
            {
                Console.WriteLine($"{Math.Floor(food - foodNeed)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeed - food)} more kilos of food are needed.");
            }

        }
    }
}
