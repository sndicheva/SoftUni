using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); //“Winter”, “Spring” или “Summer”;
            string group = Console.ReadLine();  //“boys”, “girls” или “mixed”;
            int students = int.Parse(Console.ReadLine());
            int overNights = int.Parse(Console.ReadLine());

            string sport = string.Empty;
            double price = 0;


            switch (season)
            {
                case "Winter":
                    if (group == "boys" || group == "girls")
                    {
                        price = students * 9.60 * overNights;
                        switch (group)
                        {
                            case "boys": sport = "Judo"; break;
                            case "girls": sport = "Gymnastics"; break;
                        }
                    }
                    else
                    {
                        price = students * 10 * overNights;
                        sport = "Ski";
                    }
                    break;
                case "Spring":
                    if (group == "boys" || group == "girls")
                    {
                        price = students * 7.20 * overNights;
                        switch (group)
                        {
                            case "boys": sport = "Tennis"; break;
                            case "girls": sport = "Athletics"; break;
                        }
                    }
                    else
                    {
                        price = students * 9.50 * overNights;
                        sport = "Cycling";
                    }
                    break;
                case "Summer":
                    if (group == "boys" || group == "girls")
                    {
                        price = students * 15 * overNights;
                        switch (group)
                        {
                            case "boys": sport = "Football"; break;
                            case "girls": sport = "Volleyball"; break;
                        }
                    }
                    else
                    {
                        price = students * 20 * overNights;
                        sport = "Swimming";
                    }
                    break;
            }

            if (students >= 50)
            {
                price -= price * 0.50;
            }
            else if (students >= 20 && students < 50)
            {
                price -= price * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                price -= price * 0.05;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");

        }
    }
}
