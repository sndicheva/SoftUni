using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. запазваме броя на незадоволителните оценки 
            int failedTimes = int.Parse(Console.ReadLine()); //максимален брой незадоволителни оценки които може да получи

            //2. създаваме няколко променливи:
            double evaluationSum = 0; // сбор на всички оценки
            int evaluationCount = 0;// брой на всички задачи
            string lastExercise = "";// текущото име на задача
            int evaluation;// оценка от текущата задача
            int failedCount = 0;// брояч за незадоволителните оценки (<=4), които е получил до момента

            string input = Console.ReadLine();
            //3. създаваме while цикъл


            // при всяко въртене на цикъла, четем 2 входа:
            //  име на задача - низ
            //  оценка от [2-6]

            while (input != "Enough") // докато => "Enough"
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());

                evaluationSum += evaluation;
                evaluationCount++;

                if (evaluation <= 4)
                {
                    failedCount++;
                    if (failedCount == failedTimes)// ili dokato = > count == failedTimes
                    {//=>	Ако получи определеният брой незадоволителни оценки:
                     //"You need a break, {брой незадоволителни оценки} poor grades."
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }


            //4. Отпечатваме изход, според тези 2 условия:

            //=>	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
            //o   "Average score: {средна оценка}" => цбро на всички оценки + общ брой оценки
            //o   "Number of problems: {броя на всички задачи}"
            //o   "Last problem: {името на последната задача}" името на задачата
            if (failedCount != failedTimes)
            {
                double evaluationAv = evaluationSum / evaluationCount;
                Console.WriteLine($"Average score: {evaluationAv:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
