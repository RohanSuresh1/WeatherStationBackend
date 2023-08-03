using System;

namespace WeatherStationFunctionApp.Models;

public class WeatherTelemetryData
{
    public int WeatherStationId { get; set; }
    public string WeatherStationCode { get; set; } = string.Empty;
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }
    public float AirQuality { get; set; }
    public DateTime TimeStamp { get; set; }
}