using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account credentials:
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            //int counter = 0;//


            string passwordAttempt = Console.ReadLine();

            while (passwordAttempt != password)
            {
                //counter++;//
                //Console.WriteLine("Invalid attempt");//
                //if (counter == 3)//
                //{//
                //    break;//
                //}//
                passwordAttempt = Console.ReadLine();
            }

            if (passwordAttempt == password)//
            {//
                Console.WriteLine($"Welcome {username}!");
            }//
            //else//
            //{//
            //    Console.WriteLine("Try again later!");//
            //}//


        }
    }
}
