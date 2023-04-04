using System.Text.RegularExpressions;

string pattern = @"([|#])(?<itemName>[A-Za-z\s]+)\1(?<expirationDate>\d{2}/\d{2}/\d{2})\1(?<calories>\d{1,5})\1";

const int dailyCalories = 2000;

string input = Console.ReadLine();

MatchCollection matches = Regex.Matches(input, pattern);

int totalCalories = matches.Sum(m => int.Parse(m.Groups["calories"].Value));


Console.WriteLine($"You have food to last you for: {totalCalories/dailyCalories} days!");

foreach(Match match in matches)
{
    string itemName = match.Groups["itemName"].Value;
    string expirationDate = match.Groups["expirationDate"].Value;
    int calories = int.Parse(match.Groups["calories"].Value);

    Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
}


