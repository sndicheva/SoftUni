using System;
using System.Collections.Generic;
using System.Linq;

int foodQuantity = int.Parse(Console.ReadLine());

Queue<int> orders = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
);

Console.WriteLine(orders.Max()); // print the biggest order of the input sequence

int count = orders.Count;

for (int i = 0; i < count; i++)
{
    if (foodQuantity < orders.Peek())
    {
        break;
    }
    else
    {
        foodQuantity -= orders.Peek();
        orders.Dequeue();
    }
}

if (orders.Any())
{
    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
}
else
{
    Console.WriteLine("Orders complete");
}