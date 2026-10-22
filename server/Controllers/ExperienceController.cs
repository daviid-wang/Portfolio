using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExperienceController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Experience>> Get()
    {
        var experience = new[]
        {
            new Experience(
                1,
                "Full-Stack Software Developer",
                [
                    "Built flight manifest and freight handling features used in time-sensitive daily operations.",
                    "Delivered passenger check-in and staff certification workflows end to end."
                ],
                ["C#", "ASP.NET Razor Pages", "SQL Server", "HTMX"],
                new DateOnly(2025, 1, 1),
                null,
                "Private charter airline",
                "Perth, WA"
            )
        };

        return Ok(experience);
    }
}
