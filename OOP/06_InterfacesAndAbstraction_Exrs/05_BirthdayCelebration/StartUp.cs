using BirthdayCelebration.Models;
using BirthdayCelebration.Models.Interfaces;

namespace BirthdayCelebration
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthableCollection = new();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Citizen")
                {
                    IBirthable citizen = new Citizen(tokens[3], tokens[1], int.Parse(tokens[2]), tokens[4]);
                    birthableCollection.Add(citizen);
                }
                else if (tokens[0] == "Pet")
                {
                    IBirthable pet = new Pet(tokens[1], tokens[2]);
                    birthableCollection.Add(pet);
                }
            }

            string year = Console.ReadLine();

            foreach (var element in birthableCollection)
            {
                if (element.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(element.Birthdate);
                }
            }
        }
    }
}