using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class SkillGroupsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<SkillGroup>> Get()
    {
        var skillGroups = new[]
        {
            new SkillGroup(
                "Front end",
                "What this site is built with, designed and coded from scratch.",
                [
                    new Skill(
                        "React",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Built every page of this website, the main framework recruiters ask for in front-end roles."
                    ),
                    new Skill(
                        "TypeScript",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Used across this site to catch errors early, before they reach the people visiting it."
                    ),
                    new Skill(
                        "React Router",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Lets visitors move between pages of this site instantly, without reloading."
                    ),
                    new Skill(
                        "CSS · Responsive layout",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Styled this site by hand so it looks right on phones, tablets and desktops."
                    ),
                    new Skill(
                        "Figma",
                        [Source.ThisSite, Source.CodersForCauses],
                        SkillLevel.Project,
                        "Designed this site myself before building it, and worked from designers' files in a team."
                    ),
                    new Skill(
                        "Vue.js · Tailwind CSS",
                        [Source.CodersForCauses],
                        SkillLevel.Project,
                        "Built websites for a not-for-profit debating league, which turned into a paid role."
                    )
                ]
            ),
            new SkillGroup(
                "Back end",
                "C# and .NET, from this site's API to an airline's operations.",
                [
                    new Skill(
                        "C# · .NET 10",
                        [Source.ThisSite, Source.Airline],
                        SkillLevel.Production,
                        "My main language at work, building software a charter airline relies on every day."
                    ),
                    new Skill(
                        "ASP.NET Core Razor Pages",
                        [Source.Airline],
                        SkillLevel.Production,
                        "Built the screens airline staff use daily to plan flights and record delays."
                    ),
                    new Skill(
                        "ASP.NET Core Web API",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Built the server behind this site that supplies its content."
                    ),
                    new Skill(
                        "REST APIs",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Connected this site's front end and server so they share information reliably."
                    ),
                    new Skill(
                        "Python · Flask",
                        [Source.CapstoneProject],
                        SkillLevel.Project,
                        "Built a plagiarism checker for a university academic, later used by several professors."
                    )
                ]
            ),
            new SkillGroup(
                "Data",
                "Schema changes on a live system, without downtime.",
                [
                    new Skill(
                        "SQL · Azure SQL Database",
                        [Source.Airline],
                        SkillLevel.Production,
                        "Store and report on the airline's flights, passengers, freight and pilot records."
                    ),
                    new Skill(
                        "LINQ · Linq2DB",
                        [Source.Airline],
                        SkillLevel.Production,
                        "Pull data from the airline's database to produce reports, such as delays for each pilot."
                    ),
                    new Skill(
                        "Database migrations",
                        [Source.Airline],
                        SkillLevel.Production,
                        "Updated the airline's live database with no downtime for staff."
                    )
                ]
            ),
            new SkillGroup(
                "Tooling & delivery",
                "How the code gets written, checked and shipped.",
                [
                    new Skill(
                        "Git · GitHub",
                        [Source.ThisSite, Source.Airline],
                        SkillLevel.Production,
                        "Tracks every change I make, and let me work alongside 30+ students on a shared codebase."
                    ),
                    new Skill(
                        "Vite · Prettier · dotnet format",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Keep my code fast to work on and consistently formatted."
                    ),
                    new Skill(
                        "AWS Lightsail",
                        [Source.CapstoneProject],
                        SkillLevel.Project,
                        "Put the plagiarism checker online so professors could use it on real student work."
                    ),
                    new Skill(
                        "Azure App Service",
                        [Source.ThisSite],
                        SkillLevel.Project,
                        "Hosts this website, with the React front end and .NET server deployed together."
                    ),
                    new Skill(
                        "OpenSpec · AI-assisted planning",
                        [Source.Airline],
                        SkillLevel.Learning,
                        "Learning a workflow where AI documents existing code, so new features are planned against it before any code is written."
                    )
                ]
            )
        };
        return Ok(skillGroups);
    }
}
