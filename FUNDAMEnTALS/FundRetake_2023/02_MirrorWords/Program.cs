using System.Text.RegularExpressions;

string pattern = @"([@#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

string input = Console.ReadLine();

MatchCollection matches = Regex.Matches(input, pattern);

List<KeyValuePair<string, string>> mirrorWords = new List<KeyValuePair<string, string>>();

if (matches.Count > 0)
{
    Console.WriteLine($"{matches.Count} word pairs found!");

    foreach (Match match in matches)
    {
        string firstWord = match.Groups["firstWord"].Value;
        string secondWord = match.Groups["secondWord"].Value;
        if (firstWord == new string(secondWord.Reverse().ToArray()))
        {
            mirrorWords.Add(new KeyValuePair<string, string>(firstWord, secondWord));
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
    Console.WriteLine(String.Join(", ", mirrorWords.Select(kvp =>$"{ kvp.Key} <=> {kvp.Value}")));
}
else
{
    Console.WriteLine("No mirror words!");
}