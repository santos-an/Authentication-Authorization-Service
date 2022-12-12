using CSharpFunctionalExtensions;

namespace Api.Interfaces;

public interface ITokenValidator
{
    Task<Result> Validate(string token, string refreshToken);
    bool IsExpired(string token);
}