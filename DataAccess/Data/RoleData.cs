using DataAccess.DBAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class RoleData : IRoleData
{
    private readonly ISqldbAccess _sqldbAccess;

    public RoleData(ISqldbAccess sqldbAccess)
    {
        _sqldbAccess = sqldbAccess;
    }
    //write a method to get all roles from the database
    public async Task<IEnumerable<Roles>> GetAllRolesAsync()
    {
        var roles = await _sqldbAccess.LoadData<Roles, dynamic>("uspRoles_GetAll", new { });
        return roles;
    }
}