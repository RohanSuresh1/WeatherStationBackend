using DataAccess.Models;

namespace DataAccess.Data;

public interface ISensorData
{
    Task<IEnumerable<Sensor>> GetSensorsByWeatherStationId(int weatherStationId);
    Task<int> UpdateSensorThresholds(int sensorTypeId, int weatherStationId, float maxThreshold, float minThreshold,int userId);
    Task<Sensor> GetSensorByTypeIdAndWeatherStationId(int sensorTypeId, int weatherStationId);
    Task<IEnumerable<SensorType>> GetAllSensorTypes();
}