using System;

namespace Supplies_For_School
{
    class Program
    {
        static void Main(string[] args)
        {
            // chetem 4 reda ot konzolata i gi zapazvame s promenlivi;
            // => 4 promenlivi ot tip int - 3 produkta - kolichestvo i 1 procent- procent namalenie;
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int preparationCount = int.Parse(Console.ReadLine());

            int percent = int.Parse(Console.ReadLine());

            // vseki ot 3te produkta - kolko pari shte struva
            //pen - 5.80 za broj
            //marker - 7.20 za broj
            //preparat - 1.20 za litar
            double pensPrice = pensCount * 5.80;
            double markersPrice = markersCount * 7.20;
            double preparationPrice = preparationCount * 1.20;

            // obshta suma
            double sum = pensPrice + markersPrice + preparationPrice;

            // obshta suma izvajdane procent namalenie
            double totalSum = sum - sum * (percent / 100.0); // 100.0 -> za da ne e celichisleno delenieto (int/double) samo ako percent / 100.0 e v skobi

            // otpechatvane na rezultata
            Console.WriteLine(totalSum);

        }
    }
}
