using NLog;

namespace CMCDemo_WebApi.LogConfiguration
{
    public static class LogConfigurator
    {
        public static void ConfigureLogger()
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/LogConfiguration/nLog.Config"));
        }
    }
}
