using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем входните данни и ги запаметяваме в променливи
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzleQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            // намираме общия брой играчки
            int toysQuantity = puzzleQuantity + dollsQuantity + bearsQuantity 
                + minionsQuantity + trucksQuantity;

            // намираме цаната, която ще се заплати за всеки вид играчкa
                        //намираме общата сума на играчките
            double totalPrice = puzzleQuantity * 2.6 + 
                dollsQuantity*3 + 
                bearsQuantity*4.1 + 
                minionsQuantity*8.2 + 
                trucksQuantity*2;

            //проверяваме дали броя на поръчаните/закупените играчки е >= на 50
            //=>ако са <50 не правим нищо
            //=>ако са >=50 - трябва да извадим от общата сума 25%
            if (toysQuantity >=50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            //трябва да извадим 10% от крайната сума за наем
            totalPrice = totalPrice - totalPrice * 0.10;

            //проверяваме дали печалбата е достатъчна, за да отиде на екскурзия
            //=> ако печалбата е >= цената на екскурзията
            //=> отпечатваме "да" и колко пари й остават (общата сума - цената на екскурзията)

            //=> ако печалбата е < от цената на екскурзията
            //=> отпечатваме "не" и колко пари не й достигат (цената на екс. - общата сума)

            if (totalPrice >= tripPrice)
            {
                Console.WriteLine($"Yes! {(totalPrice - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice - totalPrice):f2} lv needed.");
            }
        }
    }
}
