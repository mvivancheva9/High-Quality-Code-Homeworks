namespace Log4Net
{
    using log4net;
    using log4net.Config;

    public class Log4Net
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Log4Net));

        public static void Main()
        {
            BasicConfigurator.Configure();
            Logger.Debug("Debug msg: Something written");
            Logger.Error("Error msg: Imaginary Error");
        }
    }
}