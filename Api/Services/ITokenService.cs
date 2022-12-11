using Microsoft.AspNetCore.Identity;

namespace AuthApp.Services;

public interface ITokenService
{
    string Generate(IdentityUser user);
}