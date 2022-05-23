using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int allPoints = startPoints;
            double countWin = 0;

            for (int i = 1; i <= games; i++)
            {
                string gamePnts = (Console.ReadLine());
                switch (gamePnts) // W
                {
                    case "W":
                        allPoints += 2000;
                        countWin += 1;
                        break;
                    case "F":
                        allPoints += 1200;
                        break;
                    default:
                        allPoints += 720;
                        break;
                }
            }

            double averagePnts = (allPoints - startPoints) / games;
            //double wonGames = (countWin / games) * 100;

            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePnts)}");
            Console.WriteLine($"{(countWin / games) * 100:f2}%");
            //Console.WriteLine(wonGames);

        }
    }
}
