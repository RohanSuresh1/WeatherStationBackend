using DataAccess.Data;
using DataAccess.DBAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Utils;
using Utils.Communication;
using WeatherStationFunctionApp;


[assembly: FunctionsStartup(typeof(Startup))]
namespace WeatherStationFunctionApp;
public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        builder.Services.AddSingleton<ISqldbAccess, SqldbAccess>();
        builder.Services.AddSingleton<IServiceBusTopicManager, ServiceBusTopicManager>();
        builder.Services.AddSingleton<IEmailManager, EmailManager>();
        builder.Services.AddSingleton<ISensorData, SensorData>();
        builder.Services.AddSingleton<IUserData, UserData>();
        builder.Services.AddSingleton<IDateManager, DateManager>();
        builder.Services.AddSingleton<ISensorReadingData, SensorReadingData>();
    }
}