namespace DataAccess.Models;

public class Sensor
{
    public int SensorTypeId { get; set; }
    public int SensorConfigId { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public float MaxThreshold { get; set; }
    public float MinThreshold { get; set; }
    public int WeatherStationId { get; set; }
    public string? Units { get; set; }
    public int UserId { get; set; }
    public string WeatherStationCode { get; set; } = string.Empty;
    public string? WeatherStationName { get; set; }
}