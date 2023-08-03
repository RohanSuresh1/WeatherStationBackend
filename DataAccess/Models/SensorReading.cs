namespace DataAccess.Models;

public class SensorReading
{
    public int WeatherStationId { get; set; }
    public int SensorTypeId { get; set; }
    public float Reading { get; set; }
    public DateTime ReadingDateTime { get; set; }
    public string? SensorTypeName { get; set; }
    public string? ReadingDay { get; set; }
}