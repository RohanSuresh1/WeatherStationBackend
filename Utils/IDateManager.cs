namespace Utils
{
    public interface IDateManager
    {
        DateTime ConvertUTCToZone(DateTime utcDateTime, string Zone = "India Standard Time");
    }
}