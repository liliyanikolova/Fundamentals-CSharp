using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class Trainer : Person
    {
        public Trainer(string name, string lastName, int age)
            :base(name, lastName,age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course has been created", courseName);
        }
    }
}
