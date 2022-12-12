using Infrastructure.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ProductController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public ProductController(ApplicationDbContext dbContext) => _dbContext = dbContext;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _dbContext.Products.ToListAsync();
        
        return Ok(products);
    }
    
}