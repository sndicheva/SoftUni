using System.Reflection;

string message = Console.ReadLine();

string command = Console.ReadLine();

while (command != "Decode")
{
    string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    if (action == "Move")
    {
        int countOfLettersToMove = int.Parse(tokens[1]);

        string substring = message.Substring(0, countOfLettersToMove);
        message = message.Remove(0, countOfLettersToMove) + substring;
    }
    else if (action == "Insert")
    {
        int index = int.Parse(tokens[1]);
        string value = tokens[2];

        message = message.Insert(index, value);
    }
    else // change all
    {
        string substring = tokens[1];
        string replacement = tokens[2];

        message = message.Replace(substring, replacement);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"The decrypted message is: {message}");
