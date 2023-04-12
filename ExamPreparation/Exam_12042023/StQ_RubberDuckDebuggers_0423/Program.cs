Queue<int> times = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
Stack<int> tasks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

Dictionary<string, int> ducksGiven = new Dictionary<string, int>
{
    { "Darth Vader Ducky", 0},
    { "Thor Ducky", 0},
    { "Big Blue Rubber Ducky", 0},
    { "Small Yellow Rubber Ducky", 0}
};

while (times.Any() && tasks.Any())
{
    int time = times.Peek();
    int task = tasks.Peek();
    int result = times.Dequeue() * tasks.Pop();
    if (result >= 0 && result <= 60) // Darth Vader Ducky
    {
        ducksGiven["Darth Vader Ducky"]++;
    }
    else if (result >= 61 &&  result <= 120) // Thor Ducky
    {
        ducksGiven["Thor Ducky"]++;
    }
    else if (result >= 121 && result <= 180) // Big Blue Rubber Ducky
    {
        ducksGiven["Big Blue Rubber Ducky"]++;
    }
    else if (result >= 181 && result <= 240) // Small Yellow Rubber Ducky
    {
        ducksGiven["Small Yellow Rubber Ducky"]++;
    }
    else
    {
        times.Enqueue(time);
        tasks.Push(task-2);
    }
}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

foreach (var duck in ducksGiven)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}


