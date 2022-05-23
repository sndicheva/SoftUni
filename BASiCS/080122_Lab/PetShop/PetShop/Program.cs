using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double dogFoodSum = dogFood * 2.5;
            double catFoodSum = catFood * 4;
            double sum = dogFoodSum + catFoodSum;


            
            Console.WriteLine($"{sum} lv.");
        }
    }
}
