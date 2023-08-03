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
    public class HumidityProcessor
    {
        private readonly ILogger<HumidityProcessor> _logger;
        private readonly ISensorData _sensorData;
        private readonly IEmailManager _emailManager;
        private readonly IUserData _userData;
        private readonly IDateManager _dateManager;
        private readonly ISensorReadingData _sensorReading;

        public HumidityProcessor(ILogger<HumidityProcessor> log, ISensorData sensorData, IEmailManager emailManager, IUserData userData, IDateManager dateManager, ISensorReadingData sensorReading)
        {
            _logger = log;
            _sensorData = sensorData;
            _emailManager = emailManager;
            _userData = userData;
            _dateManager = dateManager;
            _sensorReading = sensorReading;
        }

        [FunctionName("HumidityProcessor")]
        public async Task Run([ServiceBusTrigger("weather-station-topic", "humiditySubscriber", Connection = "ServiceBusConnectionString")] string mySbMsg)
        {
            var message = ApplicationConstants.HumditiyAlertEmailTemplate;
            var humidityData = JsonConvert.DeserializeObject<WeatherTelemetryData>(mySbMsg);
            var sensorTypes = await _sensorData.GetAllSensorTypes();
            //Select the sensor type id for temperature
            var humiditySensorId = sensorTypes.FirstOrDefault(x => x.Name == "Humidity Sensor")?.SensorTypeId;
            var sensorConfigData = await _sensorData.GetSensorByTypeIdAndWeatherStationId(humiditySensorId.Value!, humidityData.WeatherStationId);
            var sensorReading = new SensorReading()
            {
                WeatherStationId = humidityData.WeatherStationId,
                SensorTypeId = humiditySensorId.Value,
                Reading = humidityData.Humidity,
                ReadingDateTime = _dateManager.ConvertUTCToZone(DateTime.UtcNow)
            };
            await _sensorReading.InsertSensorReading(sensorReading);
            if (sensorConfigData != null)
            {
                //Check if the temperature is within the threshold
                if (humidityData.Humidity > sensorConfigData.MaxThreshold || humidityData.Humidity < sensorConfigData.MinThreshold)
                {
                    var users = await _userData.GetAllUsersAsync(humidityData.WeatherStationId);
                    message = message.Replace("{sensor.Name}", sensorConfigData.Name);
                    message = message.Replace("{weatherStationName}", sensorConfigData.WeatherStationName);
                    message = message.Replace("{unit}", sensorConfigData.Units);
                    message = message.Replace("{datetime}", _dateManager.ConvertUTCToZone(DateTime.UtcNow).ToString("g"));
                    message = message.Replace("{value}", humidityData.Humidity.ToString());
                    foreach (var user in users)
                    {
                        await _emailManager.SendAlertMail(user.EmailId, message);
                    }
                }
            }
        }
    }
}
