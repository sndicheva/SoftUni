using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получаваме броя на журитo = >  n = int.Parse()
            int n = int.Parse(Console.ReadLine());
            //променлива, която ще пази входът от конзолата - input
            string input = Console.ReadLine();

            //presentationEvaluation = променлива, която ще пази сборът на всички оценки на конкретната презентация
            double presentationEvaluation = 0;

            //променлива int presentationNum = > пазим броя на всички презентации;
            int presentationNum = 0; ;
            //double evaluation => сумата от средните оценки за всяка от презентациите
            double evaluation = 0;
            string presentationName;
            //четем имена на презентации, докато не получим imput = "finish"
            //while(input != "finish")
            while (input != "Finish")
            {
                //=> нашия Input=> име на презентация
                presentationName = input;
                presentationEvaluation = 0;
                //   всеки един от журито трябва да оцени тази презентация
                //   for цикъл ot i=1 до i<=n за всеки член на журито
                for (int i = 1; i <= n; i++)
                {
                    //           => всеки един от журито ще даде оценка на тази презентация => ще се добавя към presentationEvaluation
                    presentationEvaluation += double.Parse(Console.ReadLine());
                    //           => трябва тази оценка да я добавим към сбор на всички оценки на конкретната презентация

                }

                //намираме средната оценка => personalEvaluation=presentationEvaluation/n
                presentationEvaluation = presentationEvaluation / n;

                //трябва да я добавим към сбора на всички средни оценки = > presentation...?
                evaluation += presentationEvaluation;

                //=> отпечатваме "{името на презентацията} - {средната оценката}
                Console.WriteLine($"{presentationName} - {presentationEvaluation:f2}");

                //presentationNum++;
                presentationNum++;

                //четем нов вход (input)
                input = Console.ReadLine();

            }
            //след като получим Input = "finish" => излизаме от while цикъла и отпечатваме:
            //  "Student's final assessment is {evaluation/presentationNum}."
            Console.WriteLine($"Student's final assessment is {evaluation / presentationNum:f2}.");
        }
    }
}
