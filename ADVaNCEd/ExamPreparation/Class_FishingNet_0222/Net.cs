using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            fish = new List<Fish>();
        }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;

        public int Count => this.fish.Count;

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType)
                || fish.Length <= 0
                || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }
             if (Fish.Count +1 > Capacity)
            {
                return "Fishing net is full.";
            }
            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            var fish = this.fish.FirstOrDefault(x => x.Weight == weight);
            if (fish != null)
            {
                return this.fish.Remove(fish);
            }
            return false;
        }

        public Fish GetFish(string fishType)
        {
            var fish = this.Fish.FirstOrDefault(x=>x.FishType == fishType);
            return fish;
        }

        public Fish GetBiggestFish()
            => this.fish.FirstOrDefault(x => x.Length == this.fish.Max(x => x.Length));
       
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var fish in Fish.OrderByDescending(f=>f.Length))
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
