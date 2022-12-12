using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Interfaces;
using CSharpFunctionalExtensions;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Api.Services;

public class TokenGenerator : ITokenGenerator
{
    private readonly JwtConfig _jwtConfig;
    private readonly JwtSecurityTokenHandler _handler;

    public string Token { get; private set; }
    public SecurityToken SecurityToken { get; private set; }
    public RefreshToken RefreshToken { get; private set; }

    public TokenGenerator(IOptionsMonitor<JwtConfig> optionsMonitor, JwtSecurityTokenHandler handler)
    {
        _jwtConfig = optionsMonitor.CurrentValue;
        _handler = handler;
    }

    public Result Generate(IdentityUser user)
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
            Expires = DateTime.UtcNow.AddSeconds(30),   // 5-10 min
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        SecurityToken = _handler.CreateToken(tokenDescriptor);
        Token = _handler.WriteToken(SecurityToken);
        RefreshToken = new RefreshToken
        {
            JwtId = SecurityToken.Id,
            IsUsed = false,
            IsRevoked = false,
            Created = DateTime.Now,
            ExpiryDate = DateTime.UtcNow.AddMonths(6),
            UserId = user.Id,
            Token = RandomString(35) + Guid.NewGuid()   // Refresh Token identifier
        };
        
        return Result.Success();
    }

    private static string RandomString(int length)
    {
        var random = new Random();
        var builder = new StringBuilder();
        
        for (var i = 0; i < length; i++)
        {
            var randValue = random.Next(0, 26);
            var letter = Convert.ToChar(randValue + 65);

            builder.Append(letter);
        }

        return builder.ToString();
    }
}