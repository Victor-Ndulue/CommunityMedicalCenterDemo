namespace CMCDemo.Applications.Common
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogDebugging(string message);
    }
}
