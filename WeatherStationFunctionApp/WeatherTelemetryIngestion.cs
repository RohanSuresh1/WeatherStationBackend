using Azure.Messaging.EventHubs;
using Azure.Messaging.WebPubSub;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utils.Communication;
using WeatherStationFunctionApp.Models;

namespace WeatherStationFunctionApp;

public class WeatherTelemetryIngestion
{
    private readonly IServiceBusTopicManager _serviceBusTopicManager;

    public WeatherTelemetryIngestion(IServiceBusTopicManager serviceBusTopicManager)
    {
        _serviceBusTopicManager = serviceBusTopicManager;
    }


    [FunctionName("WeatherTelemetryIngestion")]
    public async Task Run([EventHubTrigger("weather-iot-hub", Connection = "EventHubConnectionString")] EventData[] events,
        ILogger log)
    {
        var exceptions = new List<Exception>();
        string connectionString = "Endpoint=https://weather-pubsub.webpubsub.azure.com;AccessKey=hi7nC3oBt6tC2zS5bKfH5JPL1PlDe10zVaQCtzCZrbE=;Version=1.0;";
        string hubName = "hub";
        WebPubSubServiceClient client = new(connectionString, hubName);
        foreach (EventData eventData in events)
        {
            try
            {
                // Replace these two lines with your processing logic.
                log.LogInformation($"C# Event Hub trigger function processed a message: {eventData.EventBody}");
                var message = JsonConvert.DeserializeObject<WeatherTelemetryData>(eventData.EventBody.ToString());
                await _serviceBusTopicManager.SendMessage(JsonConvert.SerializeObject(message));
                // Send a message to all connected clients
                await client.SendToAllAsync(JsonConvert.SerializeObject(message));
                await Task.Yield();
            }
            catch (Exception e)
            {
                // We need to keep processing the rest of the batch - capture this exception and continue.
                // Also, consider capturing details of the message that failed processing so it can be processed again later.
                exceptions.Add(e);
            }
        }
        // Once processing of the batch is complete, if any messages in the batch failed processing throw an exception so that there is a record of the failure.

        if (exceptions.Count > 1)
            throw new AggregateException(exceptions);

        if (exceptions.Count == 1)
            throw exceptions.Single();
    }
}