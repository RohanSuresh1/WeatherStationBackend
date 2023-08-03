using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace Utils.Communication;

public class ServiceBusTopicManager : IServiceBusTopicManager
{
    private readonly IConfiguration _configuration;
    // Servicebus client
    private ServiceBusClient? _client;
    // Servicebus message sender client
    private ServiceBusSender? _sender;
    public ServiceBusTopicManager(IConfiguration configuration)
    {
        _configuration = configuration;
        Init();
    }

    private void Init()
    {
        _client = new ServiceBusClient(_configuration.GetConnectionString("ServiceBusConnectionString"));
        _sender = _client.CreateSender(_configuration.GetSection("WeatherStationTopic").Value);
    }
    public Task SendMessage(string message)
    {
        //init message and send message
        var msg = new ServiceBusMessage(Encoding.UTF8.GetBytes(message));
        return _sender.SendMessageAsync(msg);
    }
}