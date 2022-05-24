using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //трябва ни променлива, която да пази нашият вход - input
            string input = Console.ReadLine();
            // трябва да имаме променлива, в която ще запазваме текущото число - num
            int num;

            // променлива пазеща сумата на простите числа - primeSum
            // променлива за сумата на НЕпростите числа - nonPrimeSum
            int primeSum = 0;
            int nonPrimeSum = 0;

            // цикъл, който да се вътри, докато не получим input = "stop"
            while (input != "stop")
            {
                // преобразуване на input в  число, т.е. трябва да го запазим в променлива = > num = int.Parse(input)
                num = int.Parse(input);

                // правим проверка дали нашето число (num) е просто или НЕпросто
                //=> дали num  е отрицателно
                //    => игнорираме го!
                //    => отпечатваме "Number is negative"
                //    => четем нов input
                //    => приключваме изпълнението на ТОВА ЗАВЪРТАНЕ НА цикъла = > continue;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                //*кое число е просто
                //num>1
                //да се дели само на 1 и на себе си(num%1 == 0) §§ (num%num == 0)
                bool isPrime = true;

                // един цикъл, който ще разддели num на всчко едно число от 2 до num-1

                for (int i = 2; i <= num - 1; i++)
                {
                    //ако имаме Num=3
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //=> дали num  е просто или НЕпросто
                //=> ако num се радели на някое от числата без остатък, то значи че е НЕпросто число
                //   => ако е просто => primeSum += num;

                //   => ако е НЕпросто => nonPrimeSum += num;
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
                //=> трябва всеки път да четем input (с изключение на 1вия път)
                input = Console.ReadLine();
            }
                //Когато получим Input = "stop" => излизаме от while цикъла и трябва да отпечатим резултата
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            //=>"Sum of all prime numbers is: {prime numbers sum}"
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            //=>"Sum of all non prime numbers is: {nonprime numbers sum}"
        }
    }
}
