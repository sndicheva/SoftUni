using System;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 ways to break out of nested loops:
            // 1. bool flag - Излизаме от циклите и продължаваме програмата
            // 2. return; - Излиза, връща се в main метода - прекъсва програмата без да продължава кода извън циклите
            // 3. Environment.Exit(0);прекъсва програмата без да продължава кода извън циклите
            // bool flag = false; 1.


            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hour:d2}:{min:d2}");
                    // if (hour == 22 && min == 30)
                    // {
                    //    // flag = true; 1.           // return; //2.     //Environment.Exit(0);  // 3.
                    //    // break;       1.           //                  //
                    // }                                                   //
                }
                //if (flag)     1.
                //{             1.
                //    break;    1.
                //}             1.
            }
        }
    }
}
