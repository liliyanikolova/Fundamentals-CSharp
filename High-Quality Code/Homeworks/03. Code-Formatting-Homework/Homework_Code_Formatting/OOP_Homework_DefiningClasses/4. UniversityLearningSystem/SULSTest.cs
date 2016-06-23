using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UniversityLearningSystem
{
    public class SULSTest
    {
        static void Main()
        {
            List<Object> SUPeope = new List<object> { 
                           new Person ("Ivan", "Petrov",24),
                           new Person("Ina","Antonow",33),
                           new Trainer("Anton","Tomov",36),
                           new Trainer("Sibila","Stoeva",40),
                           new JuniorTrainer("Petya","Simonova",26),
                           new SeniorTrainer("Dani","Iliev",38),
                           new SeniorTrainer("Yani","Shopov",46),
                           new Student("Angel","Iliev",20,12345,5.90),
                           new Student("Anna","Atanasova",22,12444,5.40),
                           new GraduateStudent("Tanya","Nikolova",23,22551,5.00),
                           new GraduateStudent("Boris","Atanasov",25,8472,4.80),
                           new CurrentStudent("Dora","Taneva",21,54321,5.40,"OOP"),
                           new CurrentStudent("Tina","Dinova",23,55443,5.77,"Programing Basics"),
                           new CurrentStudent("Spas","Mihov",22,44552,5.00,"OOP"),
                           new CurrentStudent("Ivan","Tomov",25,32154,5.60,"Programing Basics"),
                           new CurrentStudent("Valentin","Nikolov",35,11223,6.00,"Programing Basics"),
                           new DropoutStudent("Toni","Spiriev",35,29312,5.88,"reason1"),
                           new OnlineStudent("Mira","Stoeva",27,67676,4.90,"OOP"),
                           new OnsiteStudent("Katerina","Nikolova",30,33686,5.30,"OOP",8)
            };

            List<Object> currentStudents = SUPeope.Where(st => st.GetType() == typeof(CurrentStudent)).ToList();
            List<CurrentStudent> newCurrentStudents=new List<CurrentStudent>(currentStudents.Cast<CurrentStudent>());
            List<CurrentStudent> orderStudents= newCurrentStudents.OrderBy(st =>st.AverageGrade).ToList();

            foreach (CurrentStudent student in orderStudents)
            {
                Console.WriteLine("{0} {1}, {2} years old, Student Number: {3}, Average Grade: {4}, Current Course: {5}",
                              student.Name, student.LastName, student.Age, student.StudentNumber, student.AverageGrade, student.CurrentCourse  
                    );
            }
        }
    }
}
