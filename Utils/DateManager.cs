namespace Utils;

public class DateManager : IDateManager
{
    public DateTime ConvertUTCToZone(DateTime utcDateTime, string Zone = "India Standard Time")
    {
        var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(Zone);
        var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZoneInfo);
        return localDateTime;
    }
}