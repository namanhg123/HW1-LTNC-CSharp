using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public enum Course
    {
        Java,
        Python,
        CSharp,
        JavaScript

    }

    public class Student
    {
        public string Name { get; set; }
        public int Semester { get; set; }
        public Course CourseName { get; set; }

        public Student(string name, int semester, Course courseName)
        {
            Name = name;
            Semester = semester;
            CourseName = courseName;
        }

        // Ghi đè phương thức ToString() để hiển thị thông tin đẹp hơn
        public override string ToString()
        {
            return $"| {Name,-25} | {Semester,-10} | {CourseName,-15} |";
        }
    }
}