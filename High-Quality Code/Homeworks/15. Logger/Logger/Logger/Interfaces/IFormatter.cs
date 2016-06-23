namespace Logger.Interfaces
{
    using System;

    public interface IFormatter
    {
        string Format(string msg, Level level, DateTime date);
    }
}
