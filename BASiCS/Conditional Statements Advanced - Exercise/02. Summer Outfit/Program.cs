using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входни данни от конзолата
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            // syzdawame promenlivi koito pazjat danni za obleklo i obuvki(string outfit, string shoes)
            string outfit = "";
            string shoes = "";

            //3 proverki - "Morning" , "Afternoon", "Evening"
            //във всяка проверка да имаме по 3 вътрешни проверки
            // проверяваме за температурата
            //10 <= degrees <= 18, 18 < degrees <= 24, degrees >= 25

            if (time == "Morning")
            {
                if (degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (time == "Afternoon")
            {
                if (degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else // time==Evening
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }
}
