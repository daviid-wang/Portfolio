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
                "Freelance Full-Stack Software Developer",
                [
                    "Built a Dangerous Goods certification system that tracks pilot expiry dates and blocks lapsed pilots from passenger flights, replacing manual compliance checks.",
                    "Built “copy previous manifest”, carrying passengers and freight between legs with duplicate checks, so staff no longer re-enter manifests of 60+ passengers on multi-leg flights.",
                    "Added flight delay tracking (reasons, off-blocks and arrival times) feeding a per-pilot delay report, with database migrations rolled out without disrupting live operations."
                ],
                ["C#", ".NET 10", "ASP.NET Razor Pages", "HTMX", "Linq2DB", "Azure SQL"],
                "December 2025",
                null,
                "Private charter airline",
                "Perth, WA"
            )
        };

        return Ok(experience);
    }
}
