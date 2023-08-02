using Project_4;
using System;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolData schoolData = SchoolData.GetInstance();

            
            Student student1 = DataFactory.CreateStudent("Ram", "10th", "A");
            Student student2 = DataFactory.CreateStudent("Raju", "10th", "B");
            Student student3 = DataFactory.CreateStudent("Sam", "8th", "C");
            schoolData.Students.Add(student1);
            schoolData.Students.Add(student2);
            schoolData.Students.Add(student3);
            Teacher teacher1 = DataFactory.CreateTeacher("Sravan", "10th", "A");
            Teacher teacher2 = DataFactory.CreateTeacher("RajaSekhar", "10th", "B");
            Teacher teacher3 = DataFactory.CreateTeacher("Bhanu", "8th", "C");
            schoolData.Teachers.Add(teacher1);
            schoolData.Teachers.Add(teacher2);
            schoolData.Teachers.Add(teacher3);
            Subject subject1 = DataFactory.CreateSubject("Mathematics", "MATH", teacher1);
            Subject subject3 = DataFactory.CreateSubject("PHYSICS", "PHY", teacher3);
            Subject subject2 = DataFactory.CreateSubject("Science", "SCI", teacher2);
            schoolData.Subjects.Add(subject1);
            schoolData.Subjects.Add(subject2);
            schoolData.Subjects.Add(subject3);
            // Display the lists
            Console.WriteLine("Students in the class:");
            foreach (var student in schoolData.Students)
            {
                Console.WriteLine($"Name: {student.Name}, Class: {student.Class}, Section: {student.Section}");
            }

            Console.WriteLine("\nSubjects taught by a teacher:");
            foreach (var subject in schoolData.Subjects)
            {
                Console.WriteLine($"Name: {subject.Name}, Subject Code: {subject.SubjectCode}, Teacher: {subject.Teacher.Name}");
            }

            Console.ReadLine();
        }
    }
}