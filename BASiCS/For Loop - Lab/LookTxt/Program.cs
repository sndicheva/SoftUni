using System;

namespace LookTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "SoftUni";
            //0123456 < index //zero-based index


            Console.WriteLine(text[6]); // i
            Console.WriteLine(text[0]); // S
            Console.WriteLine(text[text.Length - 1]); //posleden simvol
            Console.WriteLine(text.Length); // 7 ->свойство, което извежда дължината на текста; space също се преброява!!!

        }
    }
}
