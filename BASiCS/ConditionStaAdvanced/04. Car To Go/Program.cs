using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // "Summer" , "Winter"

            string typeOfTheCar = string.Empty; //"Cabrio" "Jeep"
            string classOfTheCar = string.Empty;//"Economy class"  "Compact class"  "Luxury class"
            double rent = 0;


            if (budget <= 100)
            {
                classOfTheCar = "Economy class";
                if (season == "Summer")
                {
                    typeOfTheCar = "Cabrio";
                    rent = budget * 0.35;
                }
                else
                {
                    typeOfTheCar = "Jeep";
                    rent = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classOfTheCar = "Compact class";
                if (season == "Summer")
                {
                    typeOfTheCar = "Cabrio";
                    rent = budget * 0.45;
                }
                else
                {
                    typeOfTheCar = "Jeep";
                    rent = budget * 0.80;
                }
            }
            else
            {
                classOfTheCar = "Luxury class";
                typeOfTheCar = "Jeep";
                rent = budget * 0.90;
            }
            Console.WriteLine(classOfTheCar);
            Console.WriteLine($"{typeOfTheCar} - { rent:f2}");
        }
    }
}
