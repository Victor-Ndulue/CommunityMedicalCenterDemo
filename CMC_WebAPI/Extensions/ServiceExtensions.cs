using CMCDemo.Applications.Common;
using CMCDemo.Persistence.Common;

namespace CMC_WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        //Creating a method for our Logging.
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }
    }
}
