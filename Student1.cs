namespace project_4
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
    }
    public class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }
    }
    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
    }
}