using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int core, double frequency)
        {
            Brand = brand;
            Core = core;
            Frequency = frequency;
        }

        public string Brand { get; set; }
        public int Core { get; set; }
        public double Frequency { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Brand} CPU:");
            sb.AppendLine($"Cores: {Core}");
            sb.AppendLine($"Frequency: {Frequency:f1} GHz");
            return sb.ToString().TrimEnd();
        }
    }
}
