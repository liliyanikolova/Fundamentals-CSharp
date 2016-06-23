namespace Logger
{
    using System;

    using global::Logger.Interfaces;

    public class Logger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender { get; set; }

        public void Info(string msg)
        {
            this.Log(msg, Level.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, Level.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, Level.Error);
        }

        public void Fatal(string msg)
        {
            this.Log(msg, Level.Fatal);
        }

        public void Critical(string msg)
        {
            this.Log(msg, Level.Critical);
        }

        private void Log(string msg, Level level)
        {
            DateTime date = DateTime.Now;
            this.Appender.Append(msg, level, date);
        }
    }
}
