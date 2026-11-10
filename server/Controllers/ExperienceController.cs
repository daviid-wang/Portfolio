using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExperienceController(PortfolioDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Experience>>> Get()
    {
        var experience = await db.Experience.AsNoTracking().OrderBy(e => e.Id).ToListAsync();

        return Ok(experience);
    }
}
