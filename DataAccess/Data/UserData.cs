using DataAccess.DBAccess;
using DataAccess.Models;
using PasswordGenerator;
using Utils;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqldbAccess _dbAccess;
    private readonly IEmailManager _emailManager;
    public UserData(ISqldbAccess dbAccess, IEmailManager emailManager)
    {
        _dbAccess = dbAccess;
        _emailManager = emailManager;
    }
    public async Task<IEnumerable<UserDetails>> GetUserByEmailId(string emailId)
    {
        var result = await _dbAccess.LoadData<UserDetails, dynamic>("uspUser_GetUserByEmail", new { p_EmailId = emailId });
        return result;
    }
    public async Task<IEnumerable<UserDetails>> GetUserByIdAsync(int userId)
    {
        var results = await _dbAccess.LoadData<UserDetails, dynamic>(storedProcedure: "uspUser_GetUserById", new { p_UserID = userId });
        return results;
    }
    public async Task<IEnumerable<UserDetails>> GetAllUsersAsync(int weatherStationId)
    {
        var results = await _dbAccess.LoadData<UserDetails, dynamic>(storedProcedure: "uspUser_GetAllUsers", new { p_WeatherStationId = weatherStationId }, "WMS");
        return results;
    }
    public async Task<int> CreateUserAsync(UserDetails userDetails, int createdBy)
    {
        var pwd = new Password(8).IncludeLowercase().IncludeNumeric().IncludeUppercase().IncludeSpecial("[]{}^_=");
        var randomPassword = pwd.Next();
        var randomPasswordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(randomPassword, 11);
        var userId = await _dbAccess.SaveData<int, dynamic>(storedProcedure: "uspUser_CreateUser", new
        {
            p_FirstName = userDetails.FirstName,
            p_LastName = userDetails.LastName,
            p_EmailId = userDetails.EmailId,
            p_Password = randomPasswordHash,
            p_ContactNumber = userDetails.ContactNumber,
            p_RoleId = userDetails.RoleId,
            p_WeatherStationId = userDetails.WeatherStationID,
            p_CreatedBy = createdBy
        });
        await _emailManager.SendDefaultPassowrdEmail(userDetails.EmailId, randomPassword);
        return userId;
    }
    public async Task<int> UpdateUserAsync(UserDetails userDetails, int updatedBy)
    {
        var userId = await _dbAccess.SaveData<int, dynamic>(storedProcedure: "uspUser_UpdateUser", new
        {
            p_UserId = userDetails.UserId,
            p_FirstName = userDetails.FirstName,
            p_LastName = userDetails.LastName,
            p_ContactNumber = userDetails.ContactNumber,
            p_UpdatedBy = updatedBy,
            p_RoleId = userDetails.RoleId,
        });
        return userId;
    }
    public Task DeleteUserAsync(int userId, int deletedBy)
    {
        return _dbAccess.SaveData<dynamic, dynamic>(storedProcedure: "uspUser_DeleteUser", new
        {
            p_UserId = userId,
            p_DeletedBy = deletedBy
        });
    }
    //write a db method to change password for a user
    public async Task<int> ChangePasswordAsync(int userId, string hashedPassword)
    {
        var result = await _dbAccess.SaveData<int, dynamic>(storedProcedure: "uspUser_ChangePassword", new
        {
            p_UserId = userId,
            p_Password = hashedPassword,
        });
        return result;
    }
    //Get all users not in weather station by id and pattern
    public async Task<IEnumerable<UserDetails>> GetAllUsersNotInWeatherStationAsync(int weatherStationId, string pattern)
    {
        var results = await _dbAccess.LoadData<UserDetails, dynamic>(storedProcedure: "uspUser_GetAllUsersNotInStation", new { p_WeatherStationId = weatherStationId, p_Pattern = pattern }, "WMS");
        return results;
    }
    //check if a user is exisiting by email and weather station id 
    public async Task<bool> CheckIfUserExistsAsync(string emailId, int weatherStationId)
    {
        var results = await _dbAccess.LoadData<bool, dynamic>(storedProcedure: "uspUser_CheckUserExistence", new { p_EmailId = emailId, p_WeatherStationId = weatherStationId }, "WMS");
        return results.FirstOrDefault();
    }
}