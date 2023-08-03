using DataAccess.Models;

namespace DataAccess.Data;
public interface IRoleData
{
    Task<IEnumerable<Roles>> GetAllRolesAsync();
}