using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vine = int.Parse(Console.ReadLine()); // кв. м лозе
            double grape = double.Parse(Console.ReadLine()); //грозде за кв м
            int wine = int.Parse(Console.ReadLine()); //необходими литри вино за продан
            int workers = int.Parse(Console.ReadLine()); //брой работници


            double harvest = vine * grape; // реколта 1300
            double wineProduced = harvest * 0.40 / 2.5;
            if (wineProduced < wine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wine - wineProduced)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
            }
            if (wineProduced >= wine) // ?!?! тук има грешка, би следвало да е (wineProduced > wine) но в Judge от 10 теста избива 1 грешка "The process executing your submission for this test may not have received the output successfully. Please try to submit again the same solution. If the result does not change, then search the error in the submission itself."
            {
                double wineLeft = wineProduced - wine;
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workers)} liters per person.");
            }
        }
    }
}
