using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //генерира всички 4цифрени числа които могат да се съставят от числата от 1 до 9 в диапазона от 1111 до 9999

            for (int k = 1; k <= 9; k++)
            {
                for (int l = 1; l <= 9; l++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            //правим проверка дали генерираното число е специално
                            if (n % i == 0 &&
                                n % j == 0 &&
                                n % l == 0 &&
                                n % k == 0)
                            {
                                Console.Write($"{k}{l}{j}{i} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
