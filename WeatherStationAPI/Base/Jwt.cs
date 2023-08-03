using DataAccess.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WeatherStationAPI.Base;

public class Jwt : IJwt
{
    private readonly IConfiguration _configuration;
    private readonly IUserData _userData;

    public Jwt(IConfiguration configuration, IUserData userData)
    {
        _configuration = configuration;
        _userData = userData;
    }

    //write a method to generate jwt token
    public string GenerateToken(string? email, string? role)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["JWT:JWTSecret"]!);
        var userDetails = _userData.GetUserByEmailId(email).Result;
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role),
                new Claim("UserId", userDetails.FirstOrDefault()?.UserId.ToString()!)
            }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
    //write a method to set jwt token in cookie http only
    public void SetTokenInCookie(HttpContext context, string token)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddDays(1),
            SameSite = SameSiteMode.None,
            Secure = true
        };
        context.Response.Cookies.Append("jwt", token, cookieOptions);
    }
    //write a method to validate jwt token
    public string? ValidateToken(string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JWT:JWTSecret"]!);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);
            var jwtToken = (JwtSecurityToken)validatedToken;
            return jwtToken.Claims.First(x => x.Type == ClaimTypes.Email).Value;
        }
        catch (Exception)
        {
            return null;
        }
    }
    //write a method to remove jwt token from cookie
    public void RemoveTokenFromCookie(HttpContext context)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            SameSite = SameSiteMode.None,
            Secure = true
        };
        context.Response.Cookies.Delete("jwt", cookieOptions);
    }
}