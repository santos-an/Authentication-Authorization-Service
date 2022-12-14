using Api.Interfaces;
using Domain.Dtos.Requests;
using Domain.Dtos.Responses;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers.OpenToAll;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ITokenGenerator _tokenGenerator;
    private readonly ApplicationDbContext _dbContext;
    private readonly ITokenValidator _validator;
    
    public AuthController(UserManager<IdentityUser> userManager, ITokenGenerator tokenGenerator, ApplicationDbContext dbContext, ITokenValidator validator)
    {
        _userManager = userManager;
        _tokenGenerator = tokenGenerator;
        _dbContext = dbContext;
        _validator = validator;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Register(UserRegistrationRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new UserRegistrationResponse
            {
                Errors = new List<string> { "Invalid paylod" },
                Success = false
            });
        }

        var existingUser = await _userManager.FindByEmailAsync(request.Email);
        if (existingUser is not null)
        {
            return BadRequest(new UserRegistrationResponse
            {
                Errors = new List<string> { "Email already in use" },
                Success = false
            });
        }

        var user = new IdentityUser { UserName = request.Username, Email = request.Email };
        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return BadRequest(new UserRegistrationResponse
            {
                Errors = result.Errors.Select(x => x.Description).ToList(),
                Success = false
            });
        }

        // add role to user
        var roleResult = await _userManager.AddToRoleAsync(user, RoleType.Normal);
        if (!roleResult.Succeeded)
        {
            return BadRequest(new RefreshTokenResponse()
            {
                Success = false,
                Errors = roleResult.Errors.Select(e => e.Description).ToList()
            });
        }

        var tokenResult = await _tokenGenerator.Generate(user);
        if (tokenResult.IsFailure)
        {
            return BadRequest(new RefreshTokenResponse()
            {
                Success = false,
                Errors = new List<string> { "Not possible to generate a new token" }
            });
        }
        
        var token = _tokenGenerator.Token;
        var refreshToken = _tokenGenerator.RefreshToken;
        await _dbContext.RefreshTokens.AddAsync(refreshToken);
        await _dbContext.SaveChangesAsync();

        var response = new UserRegistrationResponse
        {
            Token = token,
            RefreshToken = refreshToken.Token,
            Success = true
        };
        
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login(UserLoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new UserLoginResponse
            {
                Errors = new List<string>()
                {
                    "Invalid paylod"
                },
                Success = false
            });
        }
        
        var existingUser = await _userManager.FindByEmailAsync(request.Email);
        if (existingUser is null)
        {
            return BadRequest(new UserLoginResponse
            {
                Errors = new List<string> { "Invalid login request" },
                Success = false
            });
        }
        
        var isPasswordCorrect = await _userManager.CheckPasswordAsync(existingUser, request.Password);
        if (!isPasswordCorrect)
        {
            return BadRequest(new UserLoginResponse
            {
                Errors = new List<string> { "Invalid login request" },
                Success = false
            });
        }
        
        var tokenGenerationResult = await _tokenGenerator.Generate(existingUser);
        if (tokenGenerationResult.IsFailure)
        {
            return BadRequest(new UserLoginResponse()
            {
                Success = false,
                Errors = new List<string> { "Not possible to generate a new token" }
            });
        }
        
        var token = _tokenGenerator.Token;
        var refreshToken = _tokenGenerator.RefreshToken;

        await _dbContext.RefreshTokens.AddAsync(refreshToken);
        await _dbContext.SaveChangesAsync();

        var response = new UserLoginResponse
        {
            Token = token,
            RefreshToken = refreshToken.Token,
            Success = true
        };
        
        return Ok(response);
    }
    
    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateRefreshToken(NewTokenRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new RefreshTokenResponse
            {
                Errors = new List<string> { "Invalid payload" },
                Success = false
            });
        }
        
        // Validation
        var tokenValidationResult = await _validator.ValidateAsync(request.Token, request.RefreshToken);
        if (tokenValidationResult.IsFailure)
        {
            return BadRequest(new RefreshTokenResponse
            {
                Errors = new List<string> { tokenValidationResult.Error },
                Success = false
            });
        }
        
        // Expired
        var isTokenExpired = _validator.IsExpired(request.Token);
        if (!isTokenExpired)
        {
            return BadRequest(new RefreshTokenResponse
            {
                Errors = new List<string> { "Token can not be renewed because is not expired. Only expired tokens can be renewed" },
                Success = false
            });
        }

        // Update current token as USED
        var existingRefreshToken = await _dbContext.RefreshTokens.FirstOrDefaultAsync(t => t.Token == request.RefreshToken);
        existingRefreshToken.IsUsed = true;
        
        _dbContext.RefreshTokens.Update(existingRefreshToken);

        var existingUser = await _userManager.FindByIdAsync(existingRefreshToken.UserId);
        if (existingUser is null)
        {
            return BadRequest(new RefreshTokenResponse
            {
                Errors = new List<string> { "User stored in token is not valid" },
                Success = false
            });
        }
        
        // create a new Token
        var tokenResult = await _tokenGenerator.Generate(existingUser);
        if (tokenResult.IsFailure)
        {
            return BadRequest(new RefreshTokenResponse()
            {
                Success = false,
                Errors = new List<string> { "Not possible to generate a new token" }
            });
        }
        
        var token = _tokenGenerator.Token;
        var refreshToken = _tokenGenerator.RefreshToken;

        await _dbContext.RefreshTokens.AddAsync(refreshToken);
        await _dbContext.SaveChangesAsync();

        var response = new RefreshTokenResponse()
        {
            Token = token,
            RefreshToken = refreshToken.Token,
            Success = true
        };
        
        return Ok(response);
    }
}