using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PasswordGenerator;
using Utils;
using WeatherStationAPI.Base;
using WeatherStationAPI.Model;

namespace WeatherStationAPI.Controllers;

[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserData _userData;
    private readonly IJwt _jwt;
    private readonly IEmailManager _emailManager;

    public AuthController(IUserData userData, IJwt jwt, IEmailManager emailManager)
    {
        _userData = userData;
        _jwt = jwt;
        _emailManager = emailManager;
    }

    [AllowAnonymous]
    [HttpPost]
    [Route(nameof(Login))]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
    {
        var userDetails = await _userData.GetUserByEmailId(loginRequest.Username!);
        //group userdetails by emailid and add values to User model
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
        if (user.UserId != 0 && BCrypt.Net.BCrypt.EnhancedVerify(loginRequest.Password, user.Password))
        {
            var token = _jwt.GenerateToken(loginRequest.Username, user.EmailId);
            _jwt.SetTokenInCookie(HttpContext, token);
            return Ok(user);
        }
        return Unauthorized();
    }

    [AllowAnonymous]
    [HttpPost]
    [Route(nameof(Logout))]
    public IActionResult Logout()
    {
        _jwt.RemoveTokenFromCookie(HttpContext);
        return Ok();
    }
    //write a method to change password for user by using ChangePasswordModel
    [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    [HttpPost]
    [Route(nameof(ChangePassword))]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel changePasswordModel)
    {
        var userDetails = await _userData.GetUserByIdAsync(changePasswordModel.UserId);
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
        if (user.UserId != 0 && BCrypt.Net.BCrypt.EnhancedVerify(changePasswordModel.CurrentPassword, user.Password))
        {
            var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(changePasswordModel.NewPassword);
            await _userData.ChangePasswordAsync(changePasswordModel.UserId, hashedPassword);
            return Ok(new { message = "Password changed successfully" });
        }
        else
        {
            return BadRequest(new { message = "Current password is incorrect" });
        }
    }
    //write a method to reset the password for a user by using ResetPasswordModel
    [AllowAnonymous]
    [HttpPost]
    [Route(nameof(ResetPassword))]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel resetPasswordModel)
    {
        var userDetails = await _userData.GetUserByEmailId(resetPasswordModel.EmailId);
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
        if (user.UserId != 0)
        {
            var newPassword = new Password().IncludeLowercase().IncludeUppercase().IncludeNumeric().IncludeSpecial().LengthRequired(8).Next();
            var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, 11);
            await _userData.ChangePasswordAsync(user.UserId, hashedPassword);
            //send email to user with new password
            await _emailManager.SendResetPasswordAsync(user.EmailId, newPassword);
            return Ok(new { message = "Password reset successfully" });
        }
        else
        {
            return BadRequest(new { message = "Email Id is incorrect" });
        }
    }
}