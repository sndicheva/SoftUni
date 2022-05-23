using System;

namespace Conditional_Statements_Advanced___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //string weather = Console.ReadLine();
            //sunny
            //cloudy
            //icy
            //snowy
            //switch (weather)
            //{
            //    case "sunny":
            //        Console.WriteLine("Go for a walk!");
            //        break;
            //    case "cloudy":
            //        Console.WriteLine("Can be rain!");
            //        break;
            //    case "icy":
            //        Console.WriteLine("Stay home!");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid weather");
            //        break;
            //}
            //int age = 19;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Go have a bear!");
            //        break;
            //    case 20:
            //        Console.WriteLine("sdjhskdjhs");
            //        break;
            //    default:
            //        break;
            //}


            //Логически оператори - за обединяване на условия - връщат булев резултат - true/false
            //&& - логическо И
            //II - логическо ИЛИ
            //! - логичско НЕ
            int num = int.Parse(Console.ReadLine());

            if (num >= -100 && num <= 100 && num !=0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
