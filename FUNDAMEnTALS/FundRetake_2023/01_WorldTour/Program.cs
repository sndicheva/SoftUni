
string initialStops = Console.ReadLine();

string command = Console.ReadLine();

while (command != "Travel")
{
    string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

    if (tokens[0] == "Add Stop")
    {
        if (int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < initialStops.Length)
        {
            initialStops = initialStops.Insert(int.Parse(tokens[1]), tokens[2]);
        }
    }
    else if (tokens[0] == "Remove Stop")
    {
        if (int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < initialStops.Length && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < initialStops.Length)
        {
            initialStops=initialStops.Remove(int.Parse(tokens[1]), int.Parse(tokens[2])+1- int.Parse(tokens[1]));            
        }
    }
    else if(tokens[0] == "Switch")
    {
        if (initialStops.Contains(tokens[1]))
        {
            initialStops = initialStops.Replace(tokens[1], tokens[2]);
        }
    }
    Console.WriteLine(initialStops);
    command = Console.ReadLine();
}
Console.WriteLine($"Ready for world tour! Planned stops: {initialStops}");