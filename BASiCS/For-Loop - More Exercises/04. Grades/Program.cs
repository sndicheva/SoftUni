using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double topStudents = 0;
            double fiveStudents = 0;
            double fourStudents = 0;
            double failStudents = 0;
            double assessmentAll = 0;


            for (int i = 1; i <= students; i++)
            {
                double assessment = double.Parse(Console.ReadLine());
                if (assessment >= 5)
                {
                    assessmentAll += assessment;
                    topStudents += 1;
                }
                else if (assessment >= 4 && assessment <= 4.99)
                {
                    assessmentAll += assessment;
                    fiveStudents += 1;
                }
                else if (assessment >= 3 && assessment <= 3.99)
                {
                    assessmentAll += assessment;
                    fourStudents += 1;
                }
                else
                {
                    assessmentAll += assessment;
                    failStudents += 1;
                }
            }
            double averageAssessment = assessmentAll / students;
            Console.WriteLine($"Top students: {topStudents / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fiveStudents / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {fourStudents / students * 100:f2}%");
            Console.WriteLine($"Fail: {failStudents / students * 100:f2}%");
            Console.WriteLine($"Average: {averageAssessment:f2}");
        }
    }
}
