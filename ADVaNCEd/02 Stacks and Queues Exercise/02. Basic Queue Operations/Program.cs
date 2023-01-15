using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int firstToken = int.Parse(tokens[0]);
int secondToken = int.Parse(tokens[1]);
int thirdToken = int.Parse(tokens[2]);

int[] inputString = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Queue<int> queue = new();

for (int i = 0; i < firstToken; i++)
{
    queue.Enqueue(inputString[i]);
}

for (int j = 0; j < secondToken; j++)
{
    queue.Dequeue();
}

if (queue.Contains(thirdToken) && queue.Any())
{
    Console.WriteLine("true");
}
else if (queue.Any())
{
    Console.WriteLine($"{queue.Min()}");
}
else
{
    Console.WriteLine("0");
}
