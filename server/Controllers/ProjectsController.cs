using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Project>> Get()
    {
        var projects = new[]
        {
            new Project(1, "Portfolio Website", "This site.", ["ASP.NET Core", "React", "TypeScript"]),
            new Project(2, "Placeholder Project", "Replace me later.", ["C#"])
        };

        return Ok(projects);
    }
}