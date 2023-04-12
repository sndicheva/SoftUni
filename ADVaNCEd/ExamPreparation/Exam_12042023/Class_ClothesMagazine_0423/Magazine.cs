using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public List<Cloth> Clothes { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public void AddCloth(Cloth cloth)
        {
            if(Capacity > Clothes.Count)
            {
                Clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            var clothToRemove = Clothes.Find(x => x.Color == color);
            if (clothToRemove == null)
            {
                return false;
            }
            else
            {
                Clothes.Remove(clothToRemove);
                return true;
            }
        }

        public Cloth GetSmallestCloth() => Clothes.OrderBy(c => c.Size).FirstOrDefault();
        public Cloth GetCloth(string color) => Clothes.FirstOrDefault(x => x.Color == color);

        public int GetClothCount()=>Clothes.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach(Cloth cloth in Clothes.OrderBy(c => c.Size))
            {
                sb.AppendLine(cloth.ToString());
            }

            return sb.ToString().TrimEnd(); ;
        }

    }
}
