using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercise_Classes.Section_7
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GPA { get; set; }

        public Student(int id, string name, byte gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }
    }
}
