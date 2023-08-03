using DataAccess.Data;
using DataAccess.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using Utils;
using WeatherStationFunctionApp.Models;

namespace WeatherStationFunctionApp
{
    public class TemperatureProcessor
    {
        private readonly ILogger<TemperatureProcessor> _logger;
        private readonly ISensorData _sensorData;
        private readonly IEmailManager _emailManager;
        private readonly IUserData _userData;
        private readonly IDateManager _dateManager;
        private readonly ISensorReadingData _sensorReading;
        public TemperatureProcessor(ILogger<TemperatureProcessor> log, ISensorData sensorData, IEmailManager emailManager, IUserData userData, IDateManager dateManager, ISensorReadingData sensorReading)
        {
            _logger = log;
            _sensorData = sensorData;
            _emailManager = emailManager;
            _userData = userData;
            _dateManager = dateManager;
            _sensorReading = sensorReading;
        }

        [FunctionName("TemperatureProcessor")]
        public async Task Run([ServiceBusTrigger("weather-station-topic", "tempSubscriber", Connection = "ServiceBusConnectionString")] string mySbMsg)
        {
            var message = ApplicationConstants.temperautreAlert;
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
            var tempData = JsonConvert.DeserializeObject<WeatherTelemetryData>(mySbMsg);
            var sensorTypes = await _sensorData.GetAllSensorTypes();
            //Select the sensor type id for temperature
            var tempSensorId = sensorTypes.FirstOrDefault(x => x.Name == "Temperautre Sensor")?.SensorTypeId;
            var sensorConfigData = await _sensorData.GetSensorByTypeIdAndWeatherStationId(tempSensorId.Value!, tempData.WeatherStationId);
            var sensorReading = new SensorReading()
            {
                WeatherStationId = tempData.WeatherStationId,
                SensorTypeId = tempSensorId.Value,
                Reading = tempData.Temperature,
                ReadingDateTime = _dateManager.ConvertUTCToZone(DateTime.UtcNow)
            };
            await _sensorReading.InsertSensorReading(sensorReading);
            if (sensorConfigData != null)
            {
                //Check if the temperature is within the threshold
                if (tempData.Temperature > sensorConfigData.MaxThreshold || tempData.Temperature < sensorConfigData.MinThreshold)
                {
                    //Get all the users subscribed to the weather station
                    var users = await _userData.GetAllUsersAsync(tempData.WeatherStationId);
                    message = message.Replace("{sensor.Name}", sensorConfigData.Name);
                    message = message.Replace("{weatherStationName}", sensorConfigData.WeatherStationName);
                    message = message.Replace("{unit}", sensorConfigData.Units);
                    message = message.Replace("{datetime}", _dateManager.ConvertUTCToZone(DateTime.UtcNow).ToString("g"));
                    message = message.Replace("{value}", tempData.Temperature.ToString());
                    foreach (var user in users)
                    {
                        await _emailManager.SendAlertMail(user.EmailId, message);
                    }
                }
            }
        }
    }
}
