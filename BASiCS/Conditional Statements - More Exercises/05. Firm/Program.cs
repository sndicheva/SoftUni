using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursForProject = int.Parse(Console.ReadLine());
            int daysForProject = int.Parse(Console.ReadLine());
            int employersForProject = int.Parse(Console.ReadLine());

            double hoursFreeForProject = (daysForProject - daysForProject * 0.10) * 8 + 2 * employersForProject * daysForProject;
            hoursFreeForProject = Math.Floor(hoursFreeForProject);

            if (hoursFreeForProject >= hoursForProject)
            {
                Console.WriteLine($"Yes!{hoursFreeForProject - hoursForProject} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Abs(hoursFreeForProject - hoursForProject)} hours needed.");
            }
        }
    }
}
