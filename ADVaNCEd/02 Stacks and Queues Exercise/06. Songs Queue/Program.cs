
using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> songs = new(
    Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    );


while (songs.Any())
{
    string[] command = Console.ReadLine().Split();
    switch (command[0])
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Add":
            string token = string.Join(" ", command.Skip(1));
            if (songs.Contains(token))
            {
                Console.WriteLine($"{token} is already contained!");
            }
            else
            {
                songs.Enqueue(token);
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
    }
}

Console.WriteLine("No more songs!");