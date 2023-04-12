using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_WarmWinter_0421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            List<int> sets = new List<int>();
            while (hats.Any() && scarfs.Any())
            {
                //if hat>scarf => make a set=====> set = hat + scarf, then remove from collections
                int hatSize = hats.Peek();
                int scarfSize = scarfs.Peek();
                if (hatSize > scarfSize)
                {
                    sets.Add(hatSize + scarfSize);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                // scarf > hat  => remove the hat and check next hat
                else if (hatSize < scarfSize)
                {
                    hats.Pop();
                }
                // scarf == hat => remove the scarf, add 1 to hat
                else if (hatSize == scarfSize)
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
            }
            // the most expensive set
            int mostExpensive = sets.Max(s => s);

            Console.WriteLine($"The most expensive set is: {mostExpensive}");
            Console.WriteLine(string.Join(" ", sets));
        }       
    }
}
