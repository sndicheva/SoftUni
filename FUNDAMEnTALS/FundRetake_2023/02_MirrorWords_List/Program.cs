using System.Text.RegularExpressions;

string pattern = @"([@#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

string input = Console.ReadLine();

MatchCollection matches = Regex.Matches(input, pattern);

List<string> mirrorWords = new List<string>();

if (matches.Count > 0)
{
    Console.WriteLine($"{matches.Count} word pairs found!");
    foreach (Match match in matches)
    {
        string firstWord = match.Groups["firstWord"].Value;
        string secondWord = match.Groups["secondWord"].Value;
        string secondWordReversed = new string(secondWord.Reverse().ToArray());
        if (firstWord == secondWordReversed)
        {
            mirrorWords.Add(firstWord + " <=> " + secondWord);
        }
    }
}
else
{
    Console.WriteLine("No word pairs found!");
}

if (mirrorWords.Count > 0)
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(String.Join(", ", mirrorWords));
}
else
{
    Console.WriteLine("No mirror words!");
}
