namespace _UniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class UnivercityMain
    {
        static void Main()
        {
            List<object> universityPeope = new List<object> 
            { 
                           new Person("Ivan", "Petrov", 24),
                           new Person("Ina", "Antonow", 33),
                           new Trainer("Anton", "Tomov", 36),
                           new Trainer("Sibila", "Stoeva", 40),
                           new JuniorTrainer("Petya", "Simonova", 26),
                           new SeniorTrainer("Dani", "Iliev", 38),
                           new SeniorTrainer("Yani", "Shopov", 46),
                           new Student("Angel", "Iliev", 20, 12345, 5.90),
                           new Student("Anna", "Atanasova", 22, 12444, 5.40),
                           new GraduateStudent("Tanya", "Nikolova", 23, 22551, 5.00),
                           new GraduateStudent("Boris", "Atanasov", 25, 8472, 4.80),
                           new CurrentStudent("Dora", "Taneva", 21, 54321, 5.40, "OOP"),
                           new CurrentStudent("Tina", "Dinova", 23, 55443, 5.77, "Programing Basics"),
                           new CurrentStudent("Spas", "Mihov", 22, 44552, 5.00, "OOP"),
                           new CurrentStudent("Ivan", "Tomov", 25, 32154, 5.60, "Programing Basics"),
                           new CurrentStudent("Valentin", "Nikolov", 35, 11223, 6.00, "Programing Basics"),
                           new DropoutStudent("Toni", "Spiriev", 35, 29312, 5.88, "reason1"),
                           new OnlineStudent("Mira", "Stoeva", 27, 67676, 4.90, "OOP"),
                           new OnsiteStudent("Katerina", "Nikolova", 30, 33686, 5.30, "OOP", 8)
            };

            List<object> currentStudents = universityPeope.Where(st => st.GetType() == typeof(CurrentStudent)).ToList();
            List<CurrentStudent> newCurrentStudents = new List<CurrentStudent>(currentStudents.Cast<CurrentStudent>());
            List<CurrentStudent> orderStudents = newCurrentStudents.OrderBy(st => st.AverageGrade).ToList();

            foreach (CurrentStudent student in orderStudents)
            {
                StringBuilder studentInfo = new StringBuilder();
                studentInfo.Append(string.Format("{0} {1}, ", student.FirstName, student.LastName));
                studentInfo.Append(string.Format("{0} years old, ", student.Age));
                studentInfo.Append(string.Format("Student Number: {0}, ", student.StudentNumber));
                studentInfo.Append(string.Format("Average Grade: {0}, ", student.AverageGrade));
                studentInfo.Append(string.Format("Current Course: {0}", student.CurrentCourse));
                Console.WriteLine(studentInfo);
            }
        }
    }
}
