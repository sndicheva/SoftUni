using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());

            int priceBus = 200;     //•	До 3 тона – микробус(200 лева на тон)
            int priceTruck = 175;   //•	От 4 до 11 тона – камион(175 лева на тон)
            int priceTrain = 120;   //•	12 и повече тона – влак(120 лева на тон)
            int totalPriceBus = 0;
            int totalPriceTrucks = 0;
            int totalPriceTrain = 0;

            int cargoBusWeight = 0;
            int cargoTruckWeight = 0;
            int cargoTrainWeight = 0;



            for (int i = 1; i <= cargoCount; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());
                
                if (cargoWeight <= 3)
                {
                    totalPriceBus += cargoWeight * priceBus;
                    cargoBusWeight += cargoWeight;
                }
                else if (cargoWeight >= 4 && cargoWeight <= 11)
                {
                    totalPriceTrucks += cargoWeight * priceTruck;
                    cargoTruckWeight += cargoWeight;
                }
                else
                {
                    totalPriceTrain += cargoWeight * priceTrain;
                    cargoTrainWeight += cargoWeight;
                }
            }

            double cargoAllWeight = cargoBusWeight + cargoTruckWeight + cargoTrainWeight;
            double averagePriceAll = (totalPriceBus + totalPriceTrain + totalPriceTrucks) / cargoAllWeight;

            Console.WriteLine($"{averagePriceAll:f2}");
            Console.WriteLine($"{cargoBusWeight / cargoAllWeight * 100:f2}%");
            Console.WriteLine($"{cargoTruckWeight / cargoAllWeight * 100:f2}%");
            Console.WriteLine($"{cargoTrainWeight / cargoAllWeight * 100:f2}%");


        }
    }
}
