using System;

namespace CondStat_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // <  >  ==  !=   >=  <=

            bool isTrue = true;
            //isTrue = false;
            if (isTrue) 
            {
                isTrue = false; //*
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine(isTrue);//*
        }
    }
}
