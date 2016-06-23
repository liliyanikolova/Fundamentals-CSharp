namespace Exceptions_Homework.ExamProblem
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinPossibleResult = 0;
        private const int MaxPossibleResult = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinPossibleResult)
                {
                    throw new ArgumentException("Score cannot be negative number!");
                }

                if (value > MaxPossibleResult)
                {
                    throw new ArgumentException("Score cannot be above 100!");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MinPossibleResult, MaxPossibleResult, "Exam results calculated by score.");
        }
    }
}

