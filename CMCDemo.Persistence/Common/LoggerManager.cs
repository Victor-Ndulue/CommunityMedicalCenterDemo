using CMCDemo.Applications.Common;
using NLog;

namespace CMCDemo.Persistence.Common
{
    public sealed class LoggerManager : ILoggerManager

    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebugging(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}
