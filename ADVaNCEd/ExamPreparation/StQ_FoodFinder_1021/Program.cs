using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StQ_FoodFinder_1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split().Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split().Select(char.Parse));

            List<string> words = new List<string>{"pear", "flour", "pork", "olive"};
            HashSet<char> letters = new HashSet<char>();
            while (consonants.Any())
            {
                char currVowel = vowels.Dequeue();
                char currConsonant = consonants.Pop();
                vowels.Enqueue(currVowel);
                if (words.Any(w => w.Contains(currVowel)))
                {
                    letters.Add(currVowel);
                }
                if (words.Any(w => w.Contains(currConsonant)))
                {
                    letters.Add(currConsonant);
                }
            }

            List<string> wordsFound = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                foreach (char ch in letters)
                {
                    if (word.Contains(ch))
                    {
                        word = word.Remove(word.IndexOf(ch), 1);
                    }
                }
                if(word == string.Empty)
                {
                    wordsFound.Add(words[i]);
                }
            }

            Console.WriteLine($"Words found: {wordsFound.Count}");
            foreach(var word in wordsFound)
            {
                Console.WriteLine(word);
            }
        }
    }
}
