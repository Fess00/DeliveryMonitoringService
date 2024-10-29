
using DeliveryMonitoringService.Services;

namespace DeliveryMonitoringService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllers();
            builder.Services.AddScoped<ILogService, LogService>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
