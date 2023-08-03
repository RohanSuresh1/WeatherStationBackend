using Azure.Messaging.WebPubSub;
using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WeatherStationAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
public class SensorController : Controller
{
    private readonly ISensorData _sensorData;
    private readonly ISensorReadingData _sensorReadingData;

    public SensorController(ISensorData sensorData, ISensorReadingData sensorReadingData)
    {
        _sensorData = sensorData;
        _sensorReadingData = sensorReadingData;
    }
    [HttpGet]
    [Route(nameof(GetSensorsByWeatherStationId))]
    public async Task<IActionResult> GetSensorsByWeatherStationId(int weatherStationId)
    {
        var sensors = await _sensorData.GetSensorsByWeatherStationId(weatherStationId);
        return Ok(sensors);
    }
    [HttpPost]
    [Route(nameof(UpdateSensorThresholds))]
    public async Task<IActionResult> UpdateSensorThresholds(int sensorConfigId, int weatherStationId, float maxThreshold, float minThreshold, int userId)
    {
        var result = await _sensorData.UpdateSensorThresholds(sensorConfigId, weatherStationId, maxThreshold, minThreshold, userId);
        return Ok(result);
    }
    [HttpGet]
    [Route(nameof(GetLiveData))]
    public async Task<IActionResult> GetLiveData()
    {
        var serviceClient = new WebPubSubServiceClient("Endpoint=https://weather-pubsub.webpubsub.azure.com;AccessKey=hi7nC3oBt6tC2zS5bKfH5JPL1PlDe10zVaQCtzCZrbE=;Version=1.0;", "Hub");
        var accessToken = serviceClient.GetClientAccessUri();
        return Ok(new { token = accessToken });
    }
    //write a method to get sensor reading by weather station id and between dates
    [HttpGet]
    [Route(nameof(GetSensorReadingBetweenDates))]
    public async Task<IActionResult> GetSensorReadingBetweenDates(int weatherStationId, DateTime startDate, DateTime endDate)
    {
        var sensorReadings = await _sensorReadingData.GetSensorReadingBetweenDates(weatherStationId, startDate, endDate);
        return Ok(sensorReadings);
    }

}