using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthApp.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AuthApp.Services;

public class TokenService : ITokenService
{
    private readonly JwtConfig _jwtConfig;
    private readonly JwtSecurityTokenHandler _handler;
    
    public TokenService(IOptionsMonitor<JwtConfig> optionsMonitor)
    {
        _jwtConfig = optionsMonitor.CurrentValue;
        _handler = new JwtSecurityTokenHandler();
    }

    public string Generate(IdentityUser user)
    {
        var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new []
            {
                new Claim("Id", user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // id to be used for the refresh token
            }),
            Expires = DateTime.UtcNow.AddHours(6),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var securityToken = _handler.CreateToken(tokenDescriptor);

        return _handler.WriteToken(securityToken);
    }
}