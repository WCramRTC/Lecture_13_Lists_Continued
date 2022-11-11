using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13_Lists_Continued
{
    public class Student
    {
        string _name;
        int _grade;

        public Student(string name, int grade)
        {
            _name = name;
            _grade = grade;
        }

        public string Name { get => _name; set => _name = value; }
        public int Grade { get => _grade; set => _grade = value; }
    }
}
