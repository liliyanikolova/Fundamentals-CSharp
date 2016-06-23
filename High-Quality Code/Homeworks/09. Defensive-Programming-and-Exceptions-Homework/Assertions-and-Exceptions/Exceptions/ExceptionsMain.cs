namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Exceptions_Homework.ExamProblem;

    public class ExceptionsMain
    {
        public static void Main()
        {
            Console.WriteLine("********** Test Subsequence Method ************");
            try
            {
                var substr = Extraction.Subsequence("Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substr);

                var subarr = Extraction.Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
                Console.WriteLine(string.Join(" ", subarr));

                var allarr = Extraction.Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
                Console.WriteLine(string.Join(" ", allarr));

                var emptyarr = Extraction.Subsequence(new[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(string.Join(" ", emptyarr));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("********** Test ExtractEnding Method ************");

            try
            {
                Console.WriteLine(Extraction.ExtractEnding("I love C#", 2));
                Console.WriteLine(Extraction.ExtractEnding("Nakov", 4));
                Console.WriteLine(Extraction.ExtractEnding("beer", 4));
                Console.WriteLine(Extraction.ExtractEnding("Hi", 100));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("********** Test CheckPrime Method ************");

            Number.CheckPrime(23);
            Number.CheckPrime(33);

            Console.WriteLine("********** Test Exam Problem ************");

            try
            {
                List<Exam> peterExams = new List<Exam>()
                                            {
                                                new SimpleMathExam(2),
                                                new CSharpExam(55),
                                                new CSharpExam(100),
                                                new SimpleMathExam(1),
                                                new CSharpExam(0),
                                            };
                Student peter = new Student("Peter", "Petrov", peterExams);
                double peterAverageResult = peter.CalcAverageExamResultInPercents();
                Console.WriteLine("Average results = {0:p0}", peterAverageResult);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
