using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace WeatherStationAPI.Base;

public class CookieTokenAuthenticationHandler : AuthenticationHandler<JwtBearerOptions>
{
    private const string TokenCookieName = "jwt";

    public CookieTokenAuthenticationHandler(
        IOptionsMonitor<JwtBearerOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock) : base(options, logger, encoder, clock)
    {
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Cookies.ContainsKey(TokenCookieName))
        {
            return AuthenticateResult.Fail("No token cookie found.");
        }

        var token = Request.Cookies[TokenCookieName];

        // Implement your own token validation logic here
        // For example, you can manually validate the token or use a JWT validation library

        if (!ValidateToken(token))
        {
            return AuthenticateResult.Fail("Invalid token.");
        }

        var claims = new List<Claim>
        {
            // Extract claims from the token if necessary
            // For example, you can decode the JWT token and extract claims
            // and create the claims list
        };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return AuthenticateResult.Success(ticket);
    }

    private bool ValidateToken(string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("ThisIsTopSecretKey");
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);
            var jwtToken = (JwtSecurityToken)validatedToken;
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}