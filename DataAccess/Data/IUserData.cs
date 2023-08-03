using DataAccess.Models;

namespace DataAccess.Data;

public interface IUserData
{
    Task DeleteUserAsync(int userId, int deletedBy);
    Task<IEnumerable<UserDetails>> GetUserByEmailId(string emailId);
    Task<IEnumerable<UserDetails>> GetUserByIdAsync(int userId);
    Task<int> UpdateUserAsync(UserDetails userDetails, int updatedBy);
    Task<int> CreateUserAsync(UserDetails userDetails, int createdBy);
    Task<IEnumerable<UserDetails>> GetAllUsersAsync(int weatherStationId);
    Task<int> ChangePasswordAsync(int userId, string hashedPassword);
    Task<IEnumerable<UserDetails>> GetAllUsersNotInWeatherStationAsync(int weatherStationId, string pattern);
    Task<bool> CheckIfUserExistsAsync(string emailId, int weatherStationId);
}