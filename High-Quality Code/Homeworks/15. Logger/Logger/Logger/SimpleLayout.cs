namespace Logger
{
    using System;

    using global::Logger.Interfaces;

    public class SimpleLayout : IFormatter
    {
        public string Format(string msg, Level level, DateTime date)
        {
            return string.Format("<{0}> - <{1}> - <{2}>", date, level, msg);
        }
    }
}
