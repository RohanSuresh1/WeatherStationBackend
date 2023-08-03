using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace WeatherStationAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
public class RoleController : ControllerBase
{
    private readonly IRoleData _roleData;

    public RoleController(IRoleData roleData)
    {
        _roleData = roleData;
    }
    //write a get method to get all roles from the database
    [HttpGet]
    [Route(nameof(GetAllRoles))]
    public async Task<IActionResult> GetAllRoles()
    {
        var roles = await _roleData.GetAllRolesAsync();
        return Ok(roles);
    }
}
