
namespace _1.ClassStudent
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class ClassStudentMain
    {
        public static void Main(string[] args)
        {
            IList<Student> students = new List<Student>();

            IList<int> studen1Marks = new List<int>() { 5, 6, 4, 5 };
            IList<int> studen2Marks = new List<int>() { 6, 6, 6 };
            IList<int> studen3Marks = new List<int>() { 3, 2, 4, 2 };
            IList<int> studen4Marks = new List<int>() { 5, 6, 4, 5 };
            IList<int> studen5Marks = new List<int>() { 5, 6, 4 };
            IList<int> studen6Marks = new List<int>() { 2, 6, 4, 5, 6 };

            Student student1 = new Student("George", "Ivanov", 27, "123414", "02123456", "g.i@abv.bg", studen1Marks, 1);
            Student student2 = new Student("Anna", "Tomova", 22, "88121577", "0889789456", "a.t@abv.bg", studen2Marks, 2);
            Student student3 = new Student("Tanya", "Tsekova", 28, "493715", "+3592456324", "t.t@gmail.com", studen3Marks, 1);
            Student student4 = new Student("Ivan", "Andonov", 20, "779514", "089841212", "i.a@gmail.com", studen4Marks, 2);
            Student student5 = new Student("Tim", "Tasev", 24, "493214", "0898456324", "t.t@gmail.com", studen5Marks, 1);
            Student student6 = new Student("Ina", "Somonska", 25, "65871666", "+359 241212", "i.a@gmail.com", studen6Marks, 2);


            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);

            // Problem 2. Students by Group
            IList<Student> group2Students = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName).ToList();
            Console.WriteLine("********** By Group **********\n");
            foreach (var student in group2Students)
            {
                Console.WriteLine("{0} {1} - Group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }

            // Problem 3. Students by First and Last Name
            IList<Student> firstBeforeLastNameStudens =
                students.Where(s => string.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0).ToList();
            Console.WriteLine("\n***** FirstName before LastName ****\n");
            foreach (var student in firstBeforeLastNameStudens)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            // Problem 4. Students by Age
            var studentsByAge =
                students.Where(s => s.Age >= 18 && s.Age <= 24)
                    .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age })
                    .ToList();
            Console.WriteLine("\n********* Students By Age ********\n");
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("{0} {1} - Age {2}", student.FirstName, student.LastName, student.Age);
            }

            // Problem 5. Sort Students with lambda expressions
            var sortedStudents = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).ToList();

            // Problem 5. Sort Students with LINQ query
            List<Student> sortedStudents2 = (from student in students
                                             orderby student.FirstName, student.LastName descending
                                             select student)
                                  .ToList();

            Console.WriteLine("\n***** Sorted by FirstName and then by LastName ****\n");
            foreach (var student in sortedStudents2)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            // Problem 6. Filter Students by Email Domain
            List<Student> abvStudents = students.Where(s => s.Email.EndsWith("abv.bg")).ToList();
            Console.WriteLine("\n***** Sudents with abv.bg Email ****\n");
            foreach (var student in abvStudents)
            {
                Console.WriteLine("{0} {1} with email {2}", student.FirstName, student.LastName, student.Email);
            }

            // Problem 7. Filter Students by Phone
            List<Student> studentsByNumber =
                students.Where(
                    s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592") || s.Phone.StartsWith("+359 2")).ToList();
            Console.WriteLine("\n***** Sudents with phone number starting with 02 / +3592 / +395 2 ****\n");
            foreach (var student in studentsByNumber)
            {
                Console.WriteLine("{0} {1} with phone number {2}", student.FirstName, student.LastName, student.Phone);
            }

            // Problem 8. Excellent Students
            List<Student> studentsWithExcellentMarks = students.Where(s => s.Marks.Contains(6)).ToList();
            Console.WriteLine("\n***** Sudents with at least one Excellent Mark ****\n");
            foreach (var student in studentsWithExcellentMarks)
            {
                Console.WriteLine("{0} {1} with marks: {2}", student.FirstName, student.LastName, string.Join(", ", student.Marks));
            }

            // Problem 9. Weak Students
            List<Student> studentsWithPoorMarks = students.Where(s => s.Marks.Where(g => g == 2).Count() == 2).ToList();
            Console.WriteLine("\n********* Weak Students ********\n");
            foreach (var student in studentsWithPoorMarks)
            {
                Console.WriteLine("{0} {1} with marks: {2}", student.FirstName, student.LastName, string.Join(", ", student.Marks));
            }

            // Problem 10. Students Enrolled in 2014
            List<Student> studentsEnrolled2014 = students.Where(s => s.FacultyNumber.Substring(4, 2) == "14").ToList();
            Console.WriteLine("\n********* Weak Students ********\n");
            foreach (var student in studentsEnrolled2014)
            {
                Console.WriteLine("{0} {1} with faculty number: {2}", student.FirstName, student.LastName, student.FacultyNumber);
            }
        }
    }
}