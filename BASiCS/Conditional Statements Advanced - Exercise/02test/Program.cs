using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreec = int.Parse(Console.ReadLine());

            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (time == "Morning")
            {
                if (degreec <= 18 && degreec >= 10)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degreec <= 24 && degreec > 18)
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
                if (degreec <= 18 && degreec >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreec <= 24 && degreec > 18)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit"; //
                    shoes = "Barefoot"; //
                }
            }
            else if (time == "Evening")
            {
                if (degreec <= 18 && degreec >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreec <= 24 && degreec > 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degreec} degrees, get your {outfit} and {shoes}.");
        }
    }
}

