using Domain.Models;
using Infrastructure.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.AppUser)]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public ProductsController(ApplicationDbContext dbContext) => _dbContext = dbContext;

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {
        var products = await _dbContext.Products.ToListAsync();
        
        return Ok(products);
    }
    
    [HttpGet("[action]")]
    public async Task<IActionResult> Get(Guid id)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        if (product is null)
            return BadRequest(
                new { Message = $"There is no product for the given id {id}" });
        
        return Ok(product);
    }
}