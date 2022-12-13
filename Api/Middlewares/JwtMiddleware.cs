using System.IdentityModel.Tokens.Jwt;
using Microsoft.Net.Http.Headers;

namespace Api.Middlewares;

public class JwtMiddleware
{
    private const string Bearer = "bearer";
    
    private readonly RequestDelegate _next;
    private readonly JwtSecurityTokenHandler _handler;

    public JwtMiddleware(RequestDelegate next, JwtSecurityTokenHandler handler)
    {
        _handler = handler;
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var authorizationHeaders = context.Request.Headers[HeaderNames.Authorization].ToString();
        if (StartsWith(authorizationHeaders, Bearer))
        {
            // VALIDATE TOKEN ... 
            var jwt = _handler.ReadJwtToken(authorizationHeaders[Bearer.Length..].TrimStart());
        }

        await _next(context);
    }

    private static bool StartsWith(string authorizationHeaders, string value)
    {
        return authorizationHeaders.ToLower().StartsWith(value);
    }
}