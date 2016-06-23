using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string name, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(name, lastName, age, studentNumber, averageGrade)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Current course cannot be null");
                }
                this.currentCourse = value;
            }
        }
    }
}
