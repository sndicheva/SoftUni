using System;

namespace For_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //Console.WriteLine(a++); // 5 постинкрементация
            //Console.WriteLine(a);
            // Console.WriteLine(++a); // 7 преинкрементация
            //Console.WriteLine(a++ + ++a);

            // Give me 5 waffles
            //for (int counter = 0; counter < 5; counter++) 
            // {
            //    Console.WriteLine("Waffle"); 
            //}


            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine(i);
            //}

            //int n = int.Parse(Console.ReadLine());
            //n=10
            //i=+2147483647
            //for (int i = n; i <= n; i--)
            //{
            //Console.WriteLine(i);// 10,9,8,7,.........- долната граница на int -2147483648 integer overflow 
            //}


            //for (int i = n; i >=1; i--)
            //{
            //Console.WriteLine(i);// 
            //}

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i+=3)
            //{
            //Console.WriteLine(i);
            //}


            int n = int.Parse(Console.ReadLine());
            // 2 на четна степен
            // всички степени на 2 -> 0..... n

            //for (int power = 0; power <= n; power++)
            //{
            //    if (power % 2 == 0)
            //    {
            //        Console.WriteLine(Math.Pow(2, power));
            //    }
            //}
            for (int power = 0; power <= n; power+= 2)
            {
                
                    Console.WriteLine(Math.Pow(2, power));
                
            }
        }
    }
}
