using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Zoo
{
    public class Zoo
    {

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public List<Animal> Animals { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if (Capacity < Animals.Count + 1)
            {
                return "The zoo is full.";
            }
            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int removingCount = 0;
            foreach (Animal animal in Animals)
            {
                if (animal.Species == species)
                {
                    removingCount++;
                }
            }
            if (removingCount > 0)
            {
                this.Animals.RemoveAll(x => x.Species == species);
            }
            return removingCount;
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsByDiet = new List<Animal>();
            foreach (Animal animal in Animals)
            {
                if (animal.Diet == diet)
                {
                    animalsByDiet.Add(animal);
                }
            }
            return animalsByDiet;
        }
        public Animal GetAnimalByWeight(double weight)
        {
            return this.Animals.Where(animal => animal.Weight == weight).First();
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (Animal animal in Animals)
            {
                if (animal.Length <= maximumLength && animal.Length >= minimumLength)
                {
                    count++;
                }
            }
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.".ToString();
        }
    }
}
