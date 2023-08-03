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
    public class AirQualityProcessor
    {
        private readonly ISensorData _sensorData;
        private readonly IEmailManager _emailManager;
        private readonly IUserData _userData;
        private readonly IDateManager _dateManager;
        private readonly ISensorReadingData _sensorReading;
        public AirQualityProcessor(IEmailManager emailManager, ISensorData sensorData, IUserData userData, IDateManager dateManager, ISensorReadingData sensorReading)
        {
            _emailManager = emailManager;
            _sensorData = sensorData;
            _userData = userData;
            _dateManager = dateManager;
            _sensorReading = sensorReading;
        }

        [FunctionName("AirQualityProcessor")]
        public async Task Run([ServiceBusTrigger("weather-station-topic", "airSubscriber", Connection = "ServiceBusConnectionString")] string mySbMsg, ILogger logger)
        {
            var message = ApplicationConstants.AirQualityTemplate;
            var airQualityData = JsonConvert.DeserializeObject<WeatherTelemetryData>(mySbMsg);
            var sensorTypes = await _sensorData.GetAllSensorTypes();
            //Select the sensor type id for temperature
            var airQualitySensorId = sensorTypes.FirstOrDefault(x => x.Name == "Air Quality Sensor")?.SensorTypeId;
            var sensorConfigData = await _sensorData.GetSensorByTypeIdAndWeatherStationId(airQualitySensorId.Value!, airQualityData.WeatherStationId);
            var sensorReading = new SensorReading()
            {
                WeatherStationId = airQualityData.WeatherStationId,
                SensorTypeId = airQualitySensorId.Value,
                Reading = airQualityData.AirQuality,
                ReadingDateTime = _dateManager.ConvertUTCToZone(DateTime.UtcNow)
            };
            await _sensorReading.InsertSensorReading(sensorReading);
            if (sensorConfigData != null)
            {
                //Check if the temperature is within the threshold
                if (airQualityData.AirQuality > sensorConfigData.MaxThreshold || airQualityData.AirQuality < sensorConfigData.MinThreshold)
                {
                    var users = await _userData.GetAllUsersAsync(airQualityData.WeatherStationId);
                    message = message.Replace("{sensor.Name}", sensorConfigData.Name);
                    message = message.Replace("{weatherStationName}", sensorConfigData.WeatherStationName);
                    message = message.Replace("{unit}", sensorConfigData.Units);
                    message = message.Replace("{datetime}", _dateManager.ConvertUTCToZone(DateTime.UtcNow).ToString("g"));
                    message = message.Replace("{value}", airQualityData.AirQuality.ToString());
                    foreach (var user in users)
                    {
                        await _emailManager.SendAlertMail(user.EmailId, message);
                    }
                }
            }
        }
    }
}
