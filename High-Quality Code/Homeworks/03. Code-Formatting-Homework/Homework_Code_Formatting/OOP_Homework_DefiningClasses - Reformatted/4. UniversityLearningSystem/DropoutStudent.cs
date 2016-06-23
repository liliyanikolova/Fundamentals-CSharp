namespace _UniversityLearningSystem
{
    using System;
    using System.Text;

    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(
            string name, 
            string lastName, 
            int age,
            int studentNumber, 
            double averageGrade, 
            string dropoutReason)
            : base(name, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason 
        {
            get
            {
                return this.dropoutReason;
            }

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
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Name: {0}", this.FirstName));
            result.AppendLine(string.Format("Last Name: {0}", this.LastName));
            result.AppendLine(string.Format("Age: {0}", this.Age));
            result.AppendLine(string.Format("Student Number: {0}", this.StudentNumber));
            result.AppendLine(string.Format("Average Grade: {0}", this.AverageGrade));
            result.AppendLine(string.Format("Dropout Reason: {0}", this.DropoutReason));
        }
    }
}
