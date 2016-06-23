using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class Student :Person
    {
        private int studentNumber;
        private double averageGrade;

        public Student(string name, string lastName, int age, int studentNumber, double averageGrade)
            : base(name, lastName, age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber 
        {
            get { return this.studentNumber; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Student Number cannot be negative");
                }
                this.studentNumber = value;
            }
        }
        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Student average grade cannot be negative");
                }
                this.averageGrade = value;
            }
        }
    }
}
