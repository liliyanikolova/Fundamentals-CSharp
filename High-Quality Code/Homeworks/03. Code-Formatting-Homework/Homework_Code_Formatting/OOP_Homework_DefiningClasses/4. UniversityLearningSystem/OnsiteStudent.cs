using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string name, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
            : base(name, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
            this.CurrentCourse = currentCourse;
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Number of visits cannot be negative number");
                }
            }
        }
    }
}
