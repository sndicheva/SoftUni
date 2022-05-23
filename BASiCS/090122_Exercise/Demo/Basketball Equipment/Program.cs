using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем от конзолата - таксата за 1 година
            double taxPerYear = double.Parse(Console.ReadLine());


            //цена кецове, екип, топка и акс.

            // кецове –  40% по-малка от таксата за една година
            // екип –  20 % по - евтина от тази на кецовете
            // топка –  1 / 4 от цената на баскетболния екип
            // аксесоари –  1 / 5 от цената на баскетболната топка
            double shouesPrice =taxPerYear - taxPerYear * (40 / 100.0);
            double outfitPrice = shouesPrice - shouesPrice * (20 / 100.0);
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;

            //Console.WriteLine(accPrice);
            //

            //обща сума: таксата + кецове + екип + топка + акс
            double sum = taxPerYear + shouesPrice + outfitPrice + ballPrice + accPrice;

            //отпечатаме сумата на конзолата
            Console.WriteLine(sum);

        }
    }
}
