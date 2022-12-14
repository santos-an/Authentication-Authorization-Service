using System.IdentityModel.Tokens.Jwt;
using Microsoft.Net.Http.Headers;

namespace Api.Middlewares;

public class JwtMiddleware
{
    private const string Bearer = "bearer";
    
    private readonly RequestDelegate _next;
    private readonly ILogger<JwtMiddleware> _logger;
    private readonly JwtSecurityTokenHandler _handler;

    public JwtMiddleware(RequestDelegate next, ILogger<JwtMiddleware> logger, JwtSecurityTokenHandler handler)
    {
        _next = next;
        _logger = logger;
        _handler = handler;
    }

    public async Task Invoke(HttpContext context)
    {
        var authorizationHeaders = context.Request.Headers[HeaderNames.Authorization].ToString();
        if (StartsWith(authorizationHeaders, Bearer))
        {
            var jwt = _handler.ReadJwtToken(authorizationHeaders[Bearer.Length..].TrimStart());
            
            _logger.LogInformation($"Accessing a protected resource using token: {jwt.Id} id");
        }

        await _next(context);
    }

    private static bool StartsWith(string authorizationHeaders, string value)
    {
        return authorizationHeaders.ToLower().StartsWith(value);
    }
}