namespace LoggerSystem
{
    using LoggerSystem.Contracts;

    public class Logger
    {
        public Logger(IAppender appneder)
        {
            this.Appender = appneder;
        }

        public IAppender Appender { get; set; }
    }
}
