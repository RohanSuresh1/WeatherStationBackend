using DataAccess.DBAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class SensorData : ISensorData
{
    private readonly ISqldbAccess _dbAccess;

    public SensorData(ISqldbAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }
    //Get all sensors by weather station id 
    public async Task<IEnumerable<Sensor>> GetSensorsByWeatherStationId(int weatherStationId)
    {
        var parameters = new { p_WeatherStationId = weatherStationId };
        return await _dbAccess.LoadData<Sensor, dynamic>("uspSensor_GetSensorsByWeatherStationId", parameters);
    }
    //Update sensor with Max threshold and Min threshold for a specific sensortypeid and weatherstationid
    public async Task<int> UpdateSensorThresholds(int sensorConfigId, int weatherStationId, float maxThreshold, float minThreshold, int userId)
    {
        var parameters = new { p_SensorConfigId = sensorConfigId, p_WeatherStationId = weatherStationId, p_MaxThreshold = maxThreshold, p_MinThreshold = minThreshold, p_UserId = userId };
        return await _dbAccess.SaveData<Sensor, dynamic>("uspSensor_UpdateSensorThresholds", parameters);
    }
    //Get sensor by typeid and weather station id 
    public async Task<Sensor> GetSensorByTypeIdAndWeatherStationId(int sensorTypeId, int weatherStationId)
    {
        var parameters = new { p_SensorTypeId = sensorTypeId, p_WeatherStationId = weatherStationId };
        var sensors = await _dbAccess.LoadData<Sensor, dynamic>("uspSensor_GetSensorByTypeIdAndWeatherStationId", parameters, "WMS");
        return sensors.FirstOrDefault()!;
    }
    //Get all sensortypes from database 
    public async Task<IEnumerable<SensorType>> GetAllSensorTypes()
    {
        return await _dbAccess.LoadData<SensorType, dynamic>("uspSensor_GetAllSensorTypes", new { }, "WMS");
    }
}