using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EducationController(PortfolioDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Education>>> Get()
    {
        var education = await db
            .Education.AsNoTracking()
            .Include(e => e.Highlights.OrderBy(h => h.Id))
            .OrderBy(e => e.Id)
            .ToListAsync();

        return Ok(education);
    }
}
