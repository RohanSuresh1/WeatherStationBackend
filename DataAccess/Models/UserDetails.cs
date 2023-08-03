namespace DataAccess.Models
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public string? ContactNumber { get; set; }
        public bool IsDefaultPassword { get; set; }
        public bool IsActive { get; set; }
        public string? RoleName { get; set; }
        public string? RoleCode { get; set; }
        public int RoleId { get; set; }
        public int WeatherStationID { get; set; }
        public string? WeatherStationName { get; set; }
        public string? WeatherStationLocation { get; set; }
        public string? WeatherStationCode { get; set; }
    }
}
