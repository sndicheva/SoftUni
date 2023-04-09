using System.Text.RegularExpressions;

string input = Console.ReadLine();
long coolThreshold = FindCoolThreshold(input);
string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})(\1)";

MatchCollection match = Regex.Matches(input, pattern);
List<string> coolEmoji = new List<string>();
foreach (Match m in match)
{
    long coolness = 0;
    string emojiMatch = m.Groups["emoji"].Value;

    coolness = emojiMatch.Sum(c => c);

    if (coolness >= coolThreshold)
    {
        coolEmoji.Add(m.Value);
    }
}

Console.WriteLine($"Cool threshold: {coolThreshold}");
Console.WriteLine($"{match.Count} emojis found in the text. The cool ones are: ");
foreach (var emoji in coolEmoji)
{
    Console.WriteLine(emoji);
}
static int FindCoolThreshold(string input)
{
    int coolThreshold = 1;
    foreach (char ch in input)
    {
        if (char.IsDigit(ch))
        {
            coolThreshold *= int.Parse(ch.ToString());
        }
    }
    return coolThreshold;
}