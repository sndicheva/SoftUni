using System;

namespace YardGreening

{
    class Program
    {
        static void Main(string[] args)
        {
            double metersGreen = double.Parse(Console.ReadLine());
            double priceWithoutDsicount = metersGreen * 7.61;
            double discount = priceWithoutDsicount * 0.18;
            double finalPrice = priceWithoutDsicount - discount;
            Console.WriteLine($"The final price is:{priceWithoutDsicount} lv.");
            Console.WriteLine($"The discount is:{discount} lv.");
        }
    }
}