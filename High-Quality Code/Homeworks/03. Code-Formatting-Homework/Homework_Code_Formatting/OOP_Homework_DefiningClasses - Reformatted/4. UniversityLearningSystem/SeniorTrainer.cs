namespace _UniversityLearningSystem
{
    using System;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string name, string lastName, int age)
            : base(name, lastName, age)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Age = age;
        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} course has been deleted", courseName);
        }
    }
}
