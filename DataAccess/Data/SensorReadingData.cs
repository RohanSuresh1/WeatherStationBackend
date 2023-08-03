using DataAccess.DBAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class SensorReadingData : ISensorReadingData
{
    private readonly ISqldbAccess _sqldbAccess;

    public SensorReadingData(ISqldbAccess sqldbAccess)
    {
        _sqldbAccess = sqldbAccess;
    }
    //write a method to insert data of SensorReading using the Model SensorReading
    public async Task<int> InsertSensorReading(SensorReading sensorReading)
    {
        var parameters = new { p_WeatherStationId = sensorReading.WeatherStationId, p_SensorTypeId = sensorReading.SensorTypeId, p_Reading = sensorReading.Reading, p_ReadingDateTime = sensorReading.ReadingDateTime };
        return await _sqldbAccess.SaveData<SensorReading, dynamic>("uspSensorReading_InsertSensorReading", parameters);
    }
    //write a method to get sensor reading between dates and weatherstationid
    public async Task<IEnumerable<SensorReading>> GetSensorReadingBetweenDates(int weatherStationId, DateTime startDate, DateTime endDate)
    {
        var parameters = new { p_WeatherStationId = weatherStationId, p_StartDate = startDate, p_EndDate = endDate };
        return await _sqldbAccess.LoadData<SensorReading, dynamic>("uspSensorReading_GetReadingByWeatherStationId", parameters);
    }

}