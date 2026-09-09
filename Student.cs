using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        // Copy Constructor
        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Grade = other.Grade;
        }
    }
}
