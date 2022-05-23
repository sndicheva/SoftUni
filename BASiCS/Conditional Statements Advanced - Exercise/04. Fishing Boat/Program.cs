using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
              //четем вх. данни              
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0.0;
            //проверяваме сезона => начисляваме такса наем
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }
            //проверяваме броя рибари и начисляваме отстъпка
            if (fishermen <= 6)
            {
                price = price - price * 0.1; // price-=price*0.1;
            }
            else if (fishermen <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }
            //проверка за допълнително намаление >ако рибарите са четен брой и не е есен
            if (fishermen%2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }

            //проверяваме дали бюджета е достатъчен:
            //=> ако е = колко пари остават
            //=> ако НЕ е = колко пари НЕ достигат
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }



        }
    }
}
