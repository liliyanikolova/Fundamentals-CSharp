namespace Logger
{
    using global::Logger.Interfaces;

    public class LoggerMain
    {
        public static void Main()
        {
            IFormatter formatter = new SimpleLayout();

            IAppender consoleAppender = new ConsoleAppender(formatter);
            consoleAppender.ReportLevel = Level.Error;

            IAppender fileAppender = new FileAppender("test.txt", formatter);

            Logger logger = new Logger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");
        }
    }
}
