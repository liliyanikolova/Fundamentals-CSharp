namespace Logger
{
    using System;

    using global::Logger.Interfaces;

    public abstract class Appender : IAppender
    {
        private const Level DefaultReportLevel = Level.Info;

        protected Appender(IFormatter formatter, Level reportLevel = DefaultReportLevel)
        {
            this.Formatter = formatter;
            this.ReportLevel = reportLevel;
        }

        public IFormatter Formatter { get; set; }

        public Level ReportLevel { get; set; }

        public abstract void Append(string msg, Level level, DateTime date);
    }
}
