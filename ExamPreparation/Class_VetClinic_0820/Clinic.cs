using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace VetClinic
{
    public class Clinic
    {
        public List<Pet> Pet;
        public Clinic(int capacity)
        {
            Pet = new List<Pet>();
            Capacity = capacity;
        }

        public int Capacity { get; set; }

        public int Count => Pet.Count;

        public void Add(Pet pet)
        {
            if (Count < Capacity)
            {
                Pet.Add(pet);
            }
        }

        public bool Remove(string name) => Pet.RemoveAll(p => p.Name == name) > 0;
        public Pet GetPet(string name, string owner) => Pet.Where(p => p.Name == name && p.Owner == owner).FirstOrDefault();
        public Pet GetOldestPet() => Pet.OrderByDescending(p => p.Age).FirstOrDefault();
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");
            foreach (Pet pet in Pet)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
