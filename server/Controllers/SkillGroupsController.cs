using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SkillGroupsController(PortfolioDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SkillGroup>>> Get()
    {
        var skillGroups = await db
            .SkillGroups.AsNoTracking()
            .Include(g => g.Skills.OrderBy(s => s.Id))
            .OrderBy(g => g.Id)
            .ToListAsync();

        return Ok(skillGroups);
    }
}
