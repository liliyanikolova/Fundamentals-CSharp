namespace Logger.Interfaces
{
    using System;

    public interface IAppender
    {
        IFormatter Formatter { get; set; }

        Level ReportLevel { get; set; }

        void Append(string msg, Level level, DateTime date);
    }
}
