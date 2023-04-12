using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        private List<Shoe> shoes;

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            shoes = new List<Shoe>();
        }

        public IReadOnlyCollection<Shoe> Shoes => shoes;
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public int Count => shoes.Count;
        public string AddShoe(Shoe shoe)
        {
            if (StorageCapacity == shoes.Count)
            {
                return "No more space in the storage room.";
            }
            else
            {
                shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        }
        public int RemoveShoes(string material)
        {
            return shoes.RemoveAll(s=>s.Material == material);
        }
        public List<Shoe> GetShoesByType(string type)
        {
            return shoes.FindAll(s=>s.Type.ToLower() == type.ToLower());
        }
        public Shoe GetShoeBySize(double size)
        {
            return shoes.First(s => s.Size == size);
        }
        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            if (shoes.Any(s => s.Size == size && s.Type == type))
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (Shoe shoe in shoes.Where(s => s.Size == size && s.Type == type))
                {
                    sb.AppendLine(shoe.ToString());
                }
                return sb.ToString().Trim();
            }
            return "No matches found!";
        }
    }
}
