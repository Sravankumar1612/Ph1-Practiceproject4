﻿
namespace project_4
{
    public class DataFactory
    {
        public static Student CreateStudent(string name, string @class, string section)
        {
            return new Student
            {
                Name = name,
                Class = @class,
                Section = section
            };
        }

        public static Teacher CreateTeacher(string name, string @class, string section)
        {
            return new Teacher
            {
                Name = name,
                Class = @class,
                Section = section
            };
        }

        public static Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject
            {
                Name = name,
                SubjectCode = subjectCode,
                Teacher = teacher
            };
        }
    }
}