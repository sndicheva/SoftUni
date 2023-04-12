using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public List<CPU> Multiprocessor { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int Count => Multiprocessor.Count;
        public void Add(CPU cpu)
        {
            if (Capacity > Multiprocessor.Count)
            Multiprocessor.Add(cpu);
        }
        public bool Remove(string brand)
        {
            var cpuToRemove = Multiprocessor.Find(m => m.Brand == brand);
            if (cpuToRemove != null)
            {
                return Multiprocessor.Remove(cpuToRemove);
            }
            return false;
        }
        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(m => m.Frequency).First();
        }
        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(m => m.Brand == brand);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
