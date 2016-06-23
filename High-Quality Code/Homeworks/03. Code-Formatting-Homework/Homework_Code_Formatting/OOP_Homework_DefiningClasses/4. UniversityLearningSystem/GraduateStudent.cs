using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class GraduateStudent : Student
    {
        public GraduateStudent(string name, string lastName, int age, int studentNumber, double averageGrade)
            : base(name, lastName, age, studentNumber,averageGrade)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }
    }
}
