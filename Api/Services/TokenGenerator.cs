﻿using System.IdentityModel.Tokens.Jwt;
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
    private readonly Jwt _jwt;
    private readonly JwtSecurityTokenHandler _handler;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    
    public TokenGenerator(IOptionsMonitor<Jwt> optionsMonitor, JwtSecurityTokenHandler handler, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _jwt = optionsMonitor.CurrentValue;
        _handler = handler;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<Result> Generate(IdentityUser user)
    {
        var key = Encoding.ASCII.GetBytes(_jwt.Secret);
        var claims = await GetAllValidClaimsFor(user);

        var mySecurityKey = new SymmetricSecurityKey(key);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Issuer = _jwt.Issuer,
            Audience = _jwt.Audience,
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddMinutes(5),   
            SigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256Signature)
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

    private async Task<List<Claim>> GetAllValidClaimsFor(IdentityUser user)
    {
        var claims = new List<Claim>()
        {
            new("id", user.Id),
            new(JwtRegisteredClaimNames.Email, user.Email),
            new(JwtRegisteredClaimNames.Sub, user.Email),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // id to be used for the refresh token
        };

        // getting the claims from DB
        var userClaims = await _userManager.GetClaimsAsync(user);
        claims.AddRange(userClaims);
        
        // get the USER_ROLES, from the DB
        var userRoles = await _userManager.GetRolesAsync(user);
        
        // attach the roles from the DB
        foreach (var userRole in userRoles)
        {
            var existingRole = await _roleManager.FindByNameAsync(userRole);
            if (existingRole is null) continue;
            
            // add the user role to the claim
            claims.Add(new Claim(ClaimTypes.Role, userRole));
                
            // get claims assigned to a role, from the database
            var roleClaims = await _roleManager.GetClaimsAsync(existingRole);
            claims.AddRange(roleClaims);
        }

        return claims;
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
    
    public string Token { get; private set; }
    public SecurityToken SecurityToken { get; private set; }
    public RefreshToken RefreshToken { get; private set; }
}