Dictionary<string, City> town = new Dictionary<string, City>();

SetCity(town);
AttackCity(town);

PrintListOfTargets(town);

void PrintListOfTargets(Dictionary<string, City> town)
{
    if (town.Count > 0)
    {
        Console.WriteLine($"Ahoy, Captain! There are {town.Count} wealthy settlements to go to:");
        foreach (var c in town)
        {
            Console.WriteLine($"{c.Key} -> Population: {c.Value.Population} citizens, Gold: {c.Value.Gold} kg");
        }
    }
    else
    {
        Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
    }
}

void AttackCity(Dictionary<string, City> town)
{
    string events = Console.ReadLine();
    while (events != "End")
    {
        string[] eventsInfo = events.Split("=>");
        string attackType = eventsInfo[0];
        string targetCity = eventsInfo[1];
        if (attackType == "Plunder")
            Plunder(town, targetCity, eventsInfo);
        else if (attackType == "Prosper")
            Prosper(town, targetCity, eventsInfo);
        events = Console.ReadLine();
    }
}

void Prosper(Dictionary<string, City> town, string targetCity, string[] eventsInfo)
{
    int increasingGold = int.Parse(eventsInfo[2]);
    if (increasingGold < 0)
    {
        Console.WriteLine("Gold added cannot be a negative number!");
    }
    else
    {
        town[targetCity].Gold += increasingGold;
        Console.WriteLine($"{increasingGold} gold added to the city treasury. {targetCity} now has {town[targetCity].Gold} gold.");
    }
}

void Plunder(Dictionary<string, City> town, string targetCity, string[] eventsInfo)
{
    int killedPpl = int.Parse(eventsInfo[2]);
    int stolenGold = int.Parse(eventsInfo[3]);
    town[targetCity].Population -= killedPpl;
    town[targetCity].Gold -= stolenGold;
    Console.WriteLine($"{targetCity} plundered! {stolenGold} gold stolen, {killedPpl} citizens killed.");
    if (town[targetCity].Population <= 0 || town[targetCity].Gold <= 0)
    {
        town.Remove(targetCity);
        Console.WriteLine($"{targetCity} has been wiped off the map!");
    }
}

void SetCity(Dictionary<string, City> town)
{
    string command = Console.ReadLine();
    while (command != "Sail")
    {
        string[] commandInfo = command.Split("||");
        string cityName = commandInfo[0];
        int population = int.Parse(commandInfo[1]);
        int gold = int.Parse(commandInfo[2]);

        if (town.ContainsKey(cityName))
        {
            town[cityName].Population += population;
            town[cityName].Gold += gold;
        }
        else
        {
            town[cityName] = new City(population, gold);
        }
        command = Console.ReadLine();
    }
}

internal class City
{
    public City(int population, int gold)
    {
        Population = population;
        Gold = gold;
    }

    public int Population { get; set; }
    public int Gold { get; set; }
}