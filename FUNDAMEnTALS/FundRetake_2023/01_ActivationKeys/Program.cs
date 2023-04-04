
string activationKey = Console.ReadLine();

string command = Console.ReadLine();

while (command != "Generate")
{
    string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    if (action == "Contains")
    {
        if (activationKey.Contains(tokens[1]))
        {
            Console.WriteLine($"{activationKey} contains {tokens[1]}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (action == "Flip")
    {
        int startIndex = int.Parse(tokens[2]);
        int endIndex = int.Parse(tokens[3]);
        string substring = activationKey.Substring(startIndex, endIndex - startIndex);
        if (tokens[1] == "Upper")
        {
            activationKey = activationKey.Replace(substring, substring.ToUpper());
        }
        else
        {
            activationKey = activationKey.Replace(substring, substring.ToLower());
        }
        Console.WriteLine(activationKey);
    }
    else if (action == "Slice")
    {
        int startIndex = int.Parse(tokens[1]);
        int length = int.Parse(tokens[2]) - startIndex;

        activationKey = activationKey.Remove(startIndex, length);
        Console.WriteLine(activationKey);

    }
    command = Console.ReadLine();
}

Console.WriteLine($"Your activation key is: {activationKey}");