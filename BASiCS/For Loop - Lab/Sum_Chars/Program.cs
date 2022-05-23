using System;

namespace Sum_Chars
{
    class Program
    {
        static void Main(string[] args)
        {//сумиране на гласни букви
            string text = Console.ReadLine(); //hello
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i]; // 'h'

                switch (currentSymbol)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;                        
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
