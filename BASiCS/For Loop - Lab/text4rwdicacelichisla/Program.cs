using System;

namespace text4rwdicacelichisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //
            //int maxNum = 0;//ако въведем отрицателно число няма да работи коректно
            int maxNum = int.MinValue;// !!!!!
            for (int i = 0; i < n; i++)
            {
               int currentNum = int.Parse(Console.ReadLine());//
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

            }
            Console.WriteLine(maxNum);
            
        }
    }
}
