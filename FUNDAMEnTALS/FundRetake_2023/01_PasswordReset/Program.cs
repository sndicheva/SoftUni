string password = Console.ReadLine();

string command = string.Empty;
while (true)
{
    command = Console.ReadLine();

    if (command == "Done")
    {
        break;
    }

    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    switch (action)
    {
        case "TakeOdd":
            string temp = string.Empty;
            for (int i = 1; i < password.Length; i+=2)
            {
                temp += password[i];
            }
            password = temp;
            Console.WriteLine(password);
            break;
        case "Cut":
            int index = int.Parse(tokens[1]);
            int length = int.Parse(tokens[2]);
            password = password.Remove(index, length);
            Console.WriteLine(password);
            break;
        case "Substitute":
            string substring = tokens[1];
            string replacement = tokens[2];
            if (password.Contains(substring))
            {
                password = password.Replace(substring, replacement);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            break;
    }
}

Console.WriteLine($"Your password is: {password}");