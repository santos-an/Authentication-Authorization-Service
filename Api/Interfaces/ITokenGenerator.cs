using CSharpFunctionalExtensions;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Api.Interfaces;

public interface ITokenGenerator
{
    Task<Result> Generate(IdentityUser user);
    
    SecurityToken SecurityToken { get; }
    string Token { get; }
    RefreshToken RefreshToken { get; }
}