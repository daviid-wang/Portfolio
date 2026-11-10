using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[OutputCache(PolicyName = "Content")]
public class ExperienceController(PortfolioDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Experience>>> Get()
    {
        var experience = await db.Experience.AsNoTracking().OrderBy(e => e.Id).ToListAsync();

        return Ok(experience);
    }
}
