using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string name, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(name, lastName, age, studentNumber, averageGrade)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason 
        {
            get { return this.dropoutReason; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dropout reason cannot be null");
                }
                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine("Name: {0}\nLast Name: {1}\nAge: {2}\nStudent Number: {3}\nAverage Grade: {4}\nDropout Reason: {5}",
                    this.Name,this.LastName,this.Age,this.StudentNumber,this.AverageGrade,this.dropoutReason);
        }
    }
}
