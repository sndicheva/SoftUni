using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        public List<Renovator> Renovators { get; private set; }
        public string Name { get; private set; }
        public int NeededRenovators { get; private set; }
        public string Project { get; private set; }
        public int Count => Renovators.Count;
        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (Count == NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {
            var targetRenovator = Renovators.Find(r => r.Name == name);

            if (targetRenovator != null)
            {
                Renovators.Remove(targetRenovator);
            }
            return targetRenovator != null;
        }
        public int RemoveRenovatorBySpecialty(string type) => Renovators.RemoveAll(r => r.Type == type);

        public Renovator HireRenovator(string name)
        {
            var targetRenovator = Renovators.Find(r => r.Name == name);
            if (targetRenovator != null)
            {
                targetRenovator.Hired = true;
            }
            return targetRenovator;
        }
        public List<Renovator> PayRenovators(int days)
        {
            return Renovators.Where(r => r.Days >= days).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in Renovators.Where(r => r.Hired == false))
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
