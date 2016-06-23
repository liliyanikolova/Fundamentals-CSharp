namespace _UniversityLearningSystem
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(
            string name,
            string lastName,
            int age, 
            int studentNumber,
            double averageGrade,
            string currentCourse)
            : base(name, lastName, age, studentNumber, averageGrade, currentCourse)
        {
        }
    }
}
