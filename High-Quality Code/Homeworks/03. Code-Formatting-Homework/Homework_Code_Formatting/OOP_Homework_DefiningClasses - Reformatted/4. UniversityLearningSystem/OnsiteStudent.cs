namespace _UniversityLearningSystem
{
    using System;

    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(
            string name, 
            string lastName,
            int age,
            int studentNumber,
            double averageGrade, 
            string currentCourse,
            int numberOfVisits)
            : base(name, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Number of visits cannot be negative number");
                }

                this.numberOfVisits = value;
            }
        }
    }
}
