namespace _UniversityLearningSystem
{
    using System;

    public class Trainer : Person
    {
        public Trainer(string name, string lastName, int age)
            : base(name, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course has been created", courseName);
        }
    }
}
