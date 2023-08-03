namespace Utils.Communication;

public interface IServiceBusTopicManager
{
    Task SendMessage(string message);
}