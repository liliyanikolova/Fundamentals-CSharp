namespace Logger
{
    using System;
    using System.IO;

    using global::Logger.Interfaces;

    public class FileAppender : Appender
    {
        private const Level DefaultReportLevel = Level.Info;

        public FileAppender(string path, IFormatter formatter, Level reportLevel = DefaultReportLevel)
            : base(formatter, reportLevel)
        {
            this.Path = path;
        }

        public string Path { get; set; }

        public override void Append(string msg, Level level, DateTime date)
        {
            if (this.HasHigherReportLevel(level))
            {
                StreamWriter file = new StreamWriter(this.Path, true);
                file.WriteLine(this.Formatter);
                file.Close();
            }
        }

        private bool HasHigherReportLevel(Level reportLevel)
        {
            return (int)this.ReportLevel <= (int)reportLevel;
        }
    }
}
