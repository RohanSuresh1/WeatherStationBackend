using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;


namespace WeatherStationAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
public class UserController : ControllerBase
{
    private readonly IUserData _userData;

    public UserController(IUserData userData)
    {
        _userData = userData;
    }
    [HttpGet]
    [Route(nameof(GetAllUsers))]
    public async Task<IActionResult> GetAllUsers(int weatherStationId)
    {
        var users = await _userData.GetAllUsersAsync(weatherStationId);
        return Ok(users);
    }
    [HttpPost]
    [Route(nameof(CreateUser))]
    public async Task<IActionResult> CreateUser(UserDetails userDetails, int CreatedBy)
    {
        //check if a user is exisiting with the same email id and weather station id
        var existingUser = await _userData.CheckIfUserExistsAsync(userDetails.EmailId, userDetails.WeatherStationID);
        if (existingUser)
        {
            return BadRequest("User already exists");
        }
        var userId = await _userData.CreateUserAsync(userDetails, CreatedBy);
        return Ok(userId);
    }
    [HttpPost]
    [Route(nameof(UpdateUser))]
    public async Task<IActionResult> UpdateUser(UserDetails userDetails, int ModifiedBy)
    {
        var userId = await _userData.UpdateUserAsync(userDetails, ModifiedBy);
        return Ok(userId);
    }
    [HttpPost]
    [Route(nameof(DeleteUser))]
    public async Task<IActionResult> DeleteUser(int userId, int ModifiedBy)
    {
        await _userData.DeleteUserAsync(userId, ModifiedBy);
        return Ok();
    }
    //write a method to get user by userid
    [HttpGet]
    [Route(nameof(GetUserById))]
    public async Task<IActionResult> GetUserById(int userId)
    {
        var userDetails = await _userData.GetUserByIdAsync(userId);
        var user = userDetails.GroupBy(x => x.EmailId).Select(x => new User
        {
            UserId = x.FirstOrDefault()?.UserId ?? 0,
            EmailId = x.FirstOrDefault()?.EmailId ?? "",
            Password = x.FirstOrDefault()?.Password ?? "",
            FirstName = x.FirstOrDefault()?.FirstName ?? "",
            LastName = x.FirstOrDefault()?.LastName ?? "",
            RoleName = x.FirstOrDefault()?.RoleName ?? "",
            RoleCode = x.FirstOrDefault()?.RoleCode ?? "",
            ContactNumber = x.FirstOrDefault()?.ContactNumber ?? "",
            IsDefaultPassword = x.FirstOrDefault()?.IsDefaultPassword ?? false,
            WeatherStations = x.Select(y => new WeatherStation
            {
                WeatherStationID = y.WeatherStationID,
                WeatherStationName = y.WeatherStationName,
                WeatherStationLocation = y.WeatherStationLocation,
                WeatherStationCode = y.WeatherStationCode
            }).ToList()
        }).ToList().FirstOrDefault();
        return Ok(user);
    }
    //get all users not in weather station by weather station id and pattern
    [HttpGet]
    [Route(nameof(GetAllUsersNotInWeatherStation))]
    public async Task<IActionResult> GetAllUsersNotInWeatherStation(int weatherStationId, string pattern)
    {
        var users = await _userData.GetAllUsersNotInWeatherStationAsync(weatherStationId, pattern);
        return Ok(users);
    }
}