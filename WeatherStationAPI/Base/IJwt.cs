namespace WeatherStationAPI.Base;

public interface IJwt
{
    string GenerateToken(string? email, string? role);
    void SetTokenInCookie(HttpContext context, string token);
    string? ValidateToken(string token);
    void RemoveTokenFromCookie(HttpContext context);
}