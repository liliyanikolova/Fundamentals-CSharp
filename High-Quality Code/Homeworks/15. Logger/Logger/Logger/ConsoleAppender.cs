namespace Logger
{
    using System;

    using global::Logger.Interfaces;

    public class ConsoleAppender : Appender
    {
        private const Level DefaultReportLevel = Level.Info;

        public ConsoleAppender(IFormatter formatter, Level reportLevel = DefaultReportLevel)
            : base(formatter, reportLevel)
        {
        }

        public override void Append(string msg, Level level, DateTime date)
        {
            if (this.HasHigherReportLevel(level))
            {
                Console.WriteLine(this.Formatter.Format(msg, level, date));
            }
        }

        private bool HasHigherReportLevel(Level reportLevel)
        {
            return (int)this.ReportLevel <= (int)reportLevel;
        }
    }
}
