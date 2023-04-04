using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> Students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            Students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => Students.Count;
        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                Students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            if (Students.Where(s => s.FirstName == firstName && s.LastName == lastName).Any())
            {
                Student currentStudent = Students.Where(s => s.FirstName == firstName && s.LastName == lastName).FirstOrDefault();
                Students.Remove(currentStudent);
                return $"Dismissed student {currentStudent.FirstName} {currentStudent.LastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            if (Students.Any(s => s.Subject == subject))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var student in Students.Where(s => s.Subject == subject))
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }

                return sb.ToString().TrimEnd();
            }
            else
            {
                return $"No students enrolled for the subject";
            }

        }
        public int GetStudentsCount() => Students.Count;

        public Student GetStudent(string firstName, string lastName) => Students.Where(s => s.FirstName == firstName && s.LastName == lastName).FirstOrDefault();
    }
}
