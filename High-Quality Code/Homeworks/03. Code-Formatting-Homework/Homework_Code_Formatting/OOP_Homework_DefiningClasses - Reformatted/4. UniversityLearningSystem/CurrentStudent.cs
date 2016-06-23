namespace _UniversityLearningSystem
{
    using System;

    public class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(
            string name,
            string lastName,
            int age,
            int studentNumber,
            double averageGrade,
            string currentCourse)
            : base(name, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }

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
