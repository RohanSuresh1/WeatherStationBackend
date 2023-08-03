namespace DataAccess.Models;

public class User
{
    //create a model for user
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
    public List<WeatherStation>? WeatherStations { get; set; }
}