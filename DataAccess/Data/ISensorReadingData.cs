using DataAccess.Models;

namespace DataAccess.Data;

public interface ISensorReadingData
{
    Task<IEnumerable<SensorReading>> GetSensorReadingBetweenDates(int weatherStationId, DateTime startDate, DateTime endDate);
    Task<int> InsertSensorReading(SensorReading sensorReading);
}