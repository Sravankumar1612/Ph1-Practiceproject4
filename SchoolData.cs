﻿using project_4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_4
{
    public class SchoolData
    {
        private static SchoolData instance;
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> Subjects { get; set; }

        private SchoolData()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Subjects = new List<Subject>();
        }

        public static SchoolData GetInstance()
        {
            if (instance == null)
            {
                instance = new SchoolData();
            }
            return instance;
        }
    }
}
