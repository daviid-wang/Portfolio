using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Data;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController(PortfolioDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> Get()
    {
        var projects = await db
            .Projects.AsNoTracking()
            .Include(p => p.Links.OrderBy(l => l.Id))
            .OrderBy(p => p.Id)
            .ToListAsync();

        return Ok(projects);
    }
}
