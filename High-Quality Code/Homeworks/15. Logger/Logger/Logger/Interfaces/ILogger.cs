namespace Logger.Interfaces
{
    public interface ILogger
    {
        IAppender Appender { get; set; }
    }
}
