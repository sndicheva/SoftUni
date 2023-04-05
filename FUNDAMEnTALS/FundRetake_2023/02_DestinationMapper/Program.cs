using System.Text.RegularExpressions;

string pattern = @"([=/])(?<destination>[A-Z][A-Za-z]{2,})\1";

string input = Console.ReadLine();

MatchCollection matches = Regex.Matches(input, pattern);
List<string> destinations = new List<string>();
int travelPoints = 0;

foreach (Match match in matches)
{
    travelPoints += match.Groups["destination"].Value.Length;
    destinations.Add(match.Groups["destination"].Value);
}

Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");