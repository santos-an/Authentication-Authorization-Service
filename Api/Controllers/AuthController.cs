using AuthApp.Services;
using Domain.Dtos.Requests;
using Domain.Dtos.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ITokenService _tokenService;

    public AuthController(UserManager<IdentityUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Register(UserRegistrationRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new UserRegistrationResponse
            {
                Errors = new List<string>()
                {
                    "Invalid paylod"
                },
                Success = false
            });
        }

        var existingUser = await _userManager.FindByEmailAsync(request.Email);
        if (existingUser != null)
        {
            return BadRequest(new UserRegistrationResponse
            {
                Errors = new List<string>()
                {
                    "Email already in use"
                },
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
        
        var token = _tokenService.Generate(user);

        return Ok(new UserRegistrationResponse
        {
            Success = true,
            Token = token
        });
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login(UserLoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new UserRegistrationResponse
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
            return BadRequest(new UserRegistrationResponse
            {
                Errors = new List<string>()
                {
                    "Invalid login request"
                },
                Success = false
            });
        }

        var isCorrectPassword = await _userManager.CheckPasswordAsync(existingUser, request.Password);
        if (!isCorrectPassword)
        {
            return BadRequest(new UserRegistrationResponse
            {
                Errors = new List<string>()
                {
                    "Invalid login request"
                },
                Success = false
            });
        }

        var token = _tokenService.Generate(existingUser);

        return Ok(new UserRegistrationResponse()
        {
            Success = true,
            Token = token
        });
    }
}