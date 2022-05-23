using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход от конзолата
            string month = Console.ReadLine();
            int overnightStays = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceAppartment = 65;


            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    if (overnightStays > 7 && overnightStays <= 14)
                    {
                        priceStudio -= priceStudio * 0.05;
                    }
                    else if (overnightStays > 14)
                    {
                        priceStudio -= priceStudio * 0.30;
                    }
                        break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceAppartment = 68.70;
                    if (overnightStays > 14)
                    {
                        priceStudio -= priceStudio * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceAppartment = 77;
                    break;
                default:
                    break;
            }
            if (overnightStays > 14)
            {
                priceAppartment -= priceAppartment * 0.10;
            }
            Console.WriteLine($"Apartment: {overnightStays * priceAppartment:f2} lv.");
            Console.WriteLine($"Studio: {overnightStays * priceStudio:f2} lv.");
        }
    }
}
