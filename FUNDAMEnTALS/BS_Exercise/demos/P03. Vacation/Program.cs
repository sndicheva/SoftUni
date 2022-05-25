using System;


namespace NewSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopelCount = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string typeOfDay = Console.ReadLine();

            double price = 0;

            if (typeGroup == "Students")
            {
                switch (typeOfDay)
                {
                    case "Friday":
                        price = peopelCount * 8.45;
                        break;
                    case "Saturday":
                        price = peopelCount * 9.80;
                        break;
                    case "Sunday":
                        price = peopelCount * 10.46;
                        break;
                }
                if (peopelCount >= 30)
                {
                    price *= 0.85; //price -= price * 0.15;
                }
            }
            else if (typeGroup == "Business")
            {
                if (peopelCount >= 100)
                {
                    peopelCount -= 10; // price -= price / peopleCount * 10; i minava nakraja
                }
                switch (typeOfDay)
                {
                    case "Friday":
                        price = peopelCount * 10.90;
                        break;
                    case "Saturday":
                        price = peopelCount * 15.60;
                        break;
                    case "Sunday":
                        price = peopelCount * 16;
                        break;
                }
            }
            else //(typeGroup == "Regular")
            {
                switch (typeOfDay)
                {
                    case "Friday":
                        price = peopelCount * 15;
                        break;
                    case "Saturday":
                        price = peopelCount * 20;
                        break;
                    case "Sunday":
                        price = peopelCount * 22.50;
                        break;
                }
                if (peopelCount >= 10 && peopelCount <= 20)
                {
                    price *= 0.95; // price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
