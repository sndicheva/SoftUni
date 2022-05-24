using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());
            string activityKind = string.Empty;
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinSh = 0;
            int proteinBar = 0;

            double counterTrain = 0;
            double counterShoping = 0;

            for (int i = 1; i <= visitors; i++)
            {
                activityKind = Console.ReadLine();
                switch (activityKind)
                {
                    case "Back":
                        back++;
                        counterTrain++;
                        break;
                    case "Chest":
                        chest++;
                        counterTrain++;
                        break;
                    case "Legs":
                        legs++;
                        counterTrain++;
                        break;
                    case "Abs":
                        abs++;
                        counterTrain++;
                        break;
                    case "Protein shake":
                        proteinSh++;
                        counterShoping++;
                        break;
                    case "Protein bar":
                        proteinBar++;
                        counterShoping++;
                        break;
                }
            }
            double trainers = counterTrain / visitors * 100;
            double shoping = counterShoping / visitors * 100;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs"); 
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinSh} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar"); 
            Console.WriteLine($"{trainers:f2}% - work out"); 
            Console.WriteLine($"{shoping:f2}% - protein");
        }
    }
}
