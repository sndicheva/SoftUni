using System;

namespace First_Steps_In_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, 2, 5, 8, -10, -10000 ....=> int
            // 2.5, 3.6, -8.7, 1, 5 ... => double
            // text... "text/string"  => string
            // c, a, v, f..... 'c'   => char

            // int name// unic, english, smisleni; firstName - camelCase/numberInRange

            int num = 10;
            //string name = Console.ReadLine();
            //Console.Write("My name is ");
            //Console.Write(name);
            double firstPrice = 0.10;
            double secondPrice = 2.50;

            double result = firstPrice + secondPrice; // 2.5+0.10=2.60
            result = secondPrice - firstPrice; // 2.5-0.1=2.4
            result = secondPrice * num; // 2.5*90=
            result = secondPrice / num;

            Console.WriteLine(result);


        }
    }
}
