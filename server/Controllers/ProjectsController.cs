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
            new Project(
                1,
                "Portfolio Website",
                "FEATURED · 2026",
                "Designed in Figma and built from scratch. A React and TypeScript single-page app with client-side routing, served by an ASP.NET Core 10 API and deployed on Azure App Service. Built to learn React and TypeScript.",
                ["ASP.NET Core", "React", "TypeScript", "Azure App Service", "Figma"],
                [new ProjectLink("GitHub", "https://github.com/daviid-wang/Portfolio")]
            ),
            new Project(
                2,
                "Plagiarism Detection Tool",
                "UNIVERSITY · 2023",
                "A plagiarism-detection web app for a UWA academic. I built the Word metadata analysis that flags suspicious edit histories and deployed the app to AWS Lightsail. The app was used by multiple professors to detect plagiarism in student submissions.",
                ["Python", "Flask", "JavaScript", "AWS", "Lightsail"],
                [new ProjectLink("GitHub", "https://github.com/lujor20/CITS3200_Project")]
            ),
            new Project(
                3,
                "Coders for Causes",
                "NOT-FOR-PROFIT · 2022-23",
                "Responsive websites built from Figma designs for not-for-profits, including the WA Debating League, as part of a 30+ student team. It led to a paid continuation role with the League.",
                ["Vue.js", "Tailwind CSS", "Figma", "Git"],
                [
                    new ProjectLink("WADL", "https://github.com/codersforcauses/wadl"),
                    new ProjectLink("Elucidate", "https://github.com/codersforcauses/elucidate")
                ]
            )
        };
        return Ok(projects);
    }
}