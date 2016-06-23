using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class OnlineStudent : CurrentStudent
    {


        public OnlineStudent(string name, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(name, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
            this.CurrentCourse = currentCourse;
        }
    }
}
