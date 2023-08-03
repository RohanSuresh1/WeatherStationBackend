using DataAccess.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace WeatherStationAPI.Base;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IUserData _userManager;

    public JwtMiddleware(RequestDelegate next, IUserData userManager)
    {
        _next = next;
        _userManager = userManager;
    }

    public Task Invoke(HttpContext context)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (token != null)
        {
            AttachAccountToContext(context, token);
        }

        return _next(context);
    }

    private void AttachAccountToContext(HttpContext context, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("ThisIsTopSecretKey");
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidateAudience = true,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var accountId = jwtToken.Claims.First(x => x.Type == "id").Value;

            // attach account to context on successful jwt validation
            var user = _userManager.GetUserByIdAsync(int.Parse(accountId)).Result;
            context.Items["User"] = user;
            context.Items["Role"] = user.FirstOrDefault().RoleCode;
        }
        catch
        {
            // do nothing if jwt validation fails
            // account is not attached to context so request won't have access to secure routes
        }
    }
}