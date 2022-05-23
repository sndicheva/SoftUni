using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string flowersType = Console.ReadLine();
            int flowersQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;
            //5 проверки за всеки тип цветя switch case/ if else 5 prowerki
            //>смятаме цената
            //>всеки тип цвете да има вътрешна провека> за отстъпките
            if (flowersType == "Roses") //за всяко цвете
            {
                price = flowersQuantity * 5.0;
                if (flowersQuantity > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (flowersType == "Dahlias")
            {
                price = flowersQuantity * 3.80;
                if (flowersQuantity > 90)
                {
                    price -= price * 0.15;
                }
            }
            else if (flowersType == "Tulips")
            {
                price = flowersQuantity * 2.80;
                if (flowersQuantity > 80)
                {
                    price -= price * 0.15;
                }
            }
            else if (flowersType == "Narcissus")
            {
                price = flowersQuantity * 3.00;
                if (flowersQuantity < 120)
                {
                    price += price *0.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                price = flowersQuantity * 2.50;
                if (flowersQuantity < 80)
                {
                    price += price * 0.20;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersQuantity} {flowersType} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget-price):f2} leva more.");
            }
            //5 проверки за всеки тип цветя switch case/ if else 5 prowerki
            //>смятаме цената
            //>всеки тип цвете да има вътрешна провека> за отстъпките


        }
    }
}
