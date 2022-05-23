using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем от конзолата 4 входа и ги запам в 4 променливи
            double budget = double.Parse(Console.ReadLine());

            int videocardQ = int.Parse(Console.ReadLine());
            int processorsQ = int.Parse(Console.ReadLine());
            int ramQ = int.Parse(Console.ReadLine());


            //намираме сумата, която трябва да заплати за видеокартите
            //=> броя видеокарти * 250
            double videocardPrice = videocardQ * 250;

            //намираме цената на процесорите за брой
            //=> сумата за видеокартите * 0,35
            //намираме сумата за процесорите
            //=> броя на проц. * сумата за видеокартите * 0,35
            double processorsPrice = processorsQ*(videocardPrice*0.35);

            //намираме цената на рам паметта за брой
            //=> сумата за видеокартите * 0,10
            //намираме сумата за рам паметта
            //=> броя на рам п. * сумата за видеокартите * 0,10
            double ramPrice = ramQ * (videocardPrice * 0.10);

            //намираме общата сума, която трябва да заплати
            double totalPrice = videocardPrice + processorsPrice + ramPrice;

            //проверяваме ако бр видеокарти > броя на процесорите
            //=> 15% отстъпка
            if (videocardQ>processorsQ)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            //намираме разликата м/у общата сума, която трябва да заплати и бюджета
            double difference = budget - totalPrice; //500-400=100
            //проверяваме, дали има достат пари
            //=>ако парите достигат..."You have {остатъчен бюджет} leva left!"
            //=>ако парите не достигат..."Not enough money! You need {нужна сума} leva more!"
            if (difference>=0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }

        }
    }
}
