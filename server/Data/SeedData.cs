using Portfolio.Api.Models;

namespace Portfolio.Api.Data;

public static class SeedData
{
    public static void AddAll(PortfolioDbContext db)
    {
        db.Experience.AddRange(Experience);
        db.Projects.AddRange(Projects);
        db.Education.AddRange(Education);
        db.SkillGroups.AddRange(SkillGroups);
    }

    private static Experience[] Experience =>
    [
        new Experience
        {
            Role = "Freelance Full-Stack Software Developer",
            Description =
            [
                "Built a Dangerous Goods certification system that tracks pilot expiry dates and blocks lapsed pilots from passenger flights, replacing manual compliance checks.",
                "Built “copy previous manifest”, carrying passengers and freight between legs with duplicate checks, so staff no longer re-enter manifests of 60+ passengers on multi-leg flights.",
                "Added flight delay tracking (reasons, off-blocks and arrival times) feeding a per-pilot delay report, with database migrations rolled out without disrupting live operations.",
            ],
            Tech = ["C#", ".NET 10", "ASP.NET Razor Pages", "HTMX", "Linq2DB", "Azure SQL"],
            DateFrom = "December 2025",
            DateTo = null,
            Company = "Private charter airline",
            Location = "Perth, WA",
        },
    ];

    private static Project[] Projects =>
    [
        new Project
        {
            Title = "Portfolio Website",
            Eyebrow = "FEATURED · 2026",
            Description =
                "Designed in Figma and built from scratch. A React and TypeScript single-page app served by an ASP.NET Core 10 API, with its content stored in PostgreSQL (Neon) through Entity Framework Core. Deployed to Azure App Service by GitHub Actions, which applies database migrations before each release.",
            Tech =
            [
                "ASP.NET Core",
                "React",
                "TypeScript",
                "EF Core",
                "PostgreSQL",
                "Azure App Service",
                "GitHub Actions",
                "Figma",
            ],
            Links = [new ProjectLink { Label = "GitHub", Url = "https://github.com/daviid-wang/Portfolio" }],
        },
        new Project
        {
            Title = "Plagiarism Detection Tool",
            Eyebrow = "UNIVERSITY · 2023",
            Description =
                "A plagiarism-detection web app for a UWA academic. I built the Word metadata analysis that flags suspicious edit histories and deployed the app to AWS Lightsail. The app was used by multiple professors to detect plagiarism in student submissions.",
            Tech = ["Python", "Flask", "JavaScript", "AWS", "Lightsail"],
            Links = [new ProjectLink { Label = "GitHub", Url = "https://github.com/lujor20/CITS3200_Project" }],
        },
        new Project
        {
            Title = "Coders for Causes",
            Eyebrow = "NOT-FOR-PROFIT · 2022-23",
            Description =
                "Responsive websites built from Figma designs for not-for-profits, including the WA Debating League, as part of a 30+ student team. It led to a paid continuation role with the League.",
            Tech = ["Vue.js", "Tailwind CSS", "Figma", "Git"],
            Links =
            [
                new ProjectLink { Label = "WADL", Url = "https://github.com/codersforcauses/wadl" },
                new ProjectLink { Label = "Elucidate", Url = "https://github.com/codersforcauses/elucidate" },
            ],
        },
    ];

    private static Education[] Education =>
    [
        new Education
        {
            Degree = "Bachelor of Science (Software Engineering)",
            University = "University of Western Australia",
            Location = "Perth, WA",
            DateFrom = "Feb 2021",
            DateTo = "Nov 2023",
            Status = "Completed",
            Summary = null,
            Scholarship = new Scholarship
            {
                Title = "UWA Engineering Scholarship",
                Description = "Awarded for academic merit and held for the full duration of the degree.",
            },
            Highlights =
            [
                new EducationHighlight
                {
                    Eyebrow = "CAPSTONE · JUL - NOV 2023",
                    Title = "Plagiarism Detection Tool",
                    Description =
                        "Built for a UWA Associate Professor of Psychology with a team of six. I developed the Word metadata analysis that flags suspicious edit histories. MVP delivered about six weeks early, then I deployed the application on AWS Lightsail with the time remaining.",
                    Tech = ["JavaScript", "Python", "Flask", "AWS Lightsail"],
                },
                new EducationHighlight
                {
                    Eyebrow = "CODERS FOR CAUSES · DEC 2022 - MAR 2023",
                    Title = "Not-for-profit websites",
                    Description =
                        "Responsive pages from Figma designs for the WA Debating League, Elucidate and Pets of Older Persons, in a 30+ student team. Selected for a paid continuation role with the Debating League.",
                    Tech = ["Vue.js", "Tailwind CSS", "Figma"],
                },
                new EducationHighlight
                {
                    Eyebrow = "STUDY TOUR · SEOUL · NOV - DEC 2022",
                    Title = "Cyber security study tour, Korea",
                    Description =
                        "Three weeks in Seoul as part of the penetration testing unit, meeting students from Korea University and Seoul Women's University, hearing their capstone project presentations and discussing what we'd covered in class. I also gave a presentation to Korea University students on reverse engineering as a security vulnerability.",
                    Tech = ["Public presentation", "Reverse engineering", "Ghidra", "Kali Linux"],
                },
            ],
            Units =
            [
                "Data Structures and Algorithms",
                "Agile Web Development",
                "Digital Embedded Systems",
                "Systems Programming",
                "Computer Networks",
                "Professional Computing",
                "Penetration Testing",
            ],
        },
        new Education
        {
            Degree = "Master of Professional Engineering (Software Engineering)",
            University = "University of Western Australia",
            Location = "Perth, WA",
            DateFrom = "Feb 2024",
            DateTo = "Nov 2024",
            Status = "One year completed",
            Summary =
                "Completed one year of postgraduate study, then left the program to pursue professional software development.",
            Scholarship = new Scholarship
            {
                Title = "UWA Engineering Scholarship",
                Description = "Awarded for academic merit.",
            },
            Highlights =
            [
                new EducationHighlight
                {
                    Eyebrow = "MOBILE ROBOTS · 2024",
                    Title = "Autonomous mapping robot",
                    Description =
                        "Integrated our software with an existing robot so it could navigate and map an area on its own. Using its camera, the robot recognised hand-drawn numbers placed around the area and recorded where each one was on the map.",
                    Tech = ["Autonomous navigation", "Mapping", "Computer vision", "Hardware integration"],
                },
                new EducationHighlight
                {
                    Eyebrow = "AI & ADAPTIVE SYSTEMS · 2024",
                    Title = "Eye scan analysis with a neural network",
                    Description =
                        "Built a neural network that analyses eye scans and automatically highlights irregularities. Adjusted the network's weights and compared the results to see how each change affected its accuracy.",
                    Tech = ["Neural networks", "Image analysis", "Model evaluation"],
                },
            ],
            Units =
            [
                "Software Requirements and Design",
                "Software Testing and Quality Assurance",
                "Mobile Robots",
                "Artificial Intelligence and Adaptive Systems",
            ],
        },
    ];

    private static SkillGroup[] SkillGroups =>
    [
        new SkillGroup
        {
            Title = "Front end",
            Summary = "What this site is built with, designed and coded from scratch.",
            Skills =
            [
                new Skill
                {
                    Name = "React",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Built every page of this website, the main framework recruiters ask for in front-end roles.",
                },
                new Skill
                {
                    Name = "TypeScript",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Used across this site to catch errors early, before they reach the people visiting it.",
                },
                new Skill
                {
                    Name = "React Router",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Lets visitors move between pages of this site instantly, without reloading.",
                },
                new Skill
                {
                    Name = "CSS · Responsive layout",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Styled this site by hand so it looks right on phones, tablets and desktops.",
                },
                new Skill
                {
                    Name = "Figma",
                    Source = [Source.ThisSite, Source.CodersForCauses],
                    Level = SkillLevel.Project,
                    Description = "Designed this site myself before building it, and worked from designers' files in a team.",
                },
                new Skill
                {
                    Name = "Vue.js · Tailwind CSS",
                    Source = [Source.CodersForCauses],
                    Level = SkillLevel.Project,
                    Description = "Built websites for a not-for-profit debating league, which turned into a paid role.",
                },
            ],
        },
        new SkillGroup
        {
            Title = "Back end",
            Summary = "C# and .NET, from this site's API to an airline's operations.",
            Skills =
            [
                new Skill
                {
                    Name = "C# · .NET 10",
                    Source = [Source.ThisSite, Source.Airline],
                    Level = SkillLevel.Production,
                    Description = "My main language at work, building software a charter airline relies on every day.",
                },
                new Skill
                {
                    Name = "ASP.NET Core Razor Pages",
                    Source = [Source.Airline],
                    Level = SkillLevel.Production,
                    Description = "Built the screens airline staff use daily to plan flights and record delays.",
                },
                new Skill
                {
                    Name = "ASP.NET Core Web API",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Built the server behind this site that supplies its content.",
                },
                new Skill
                {
                    Name = "REST APIs",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Connected this site's front end and server so they share information reliably.",
                },
                new Skill
                {
                    Name = "Python · Flask",
                    Source = [Source.CapstoneProject],
                    Level = SkillLevel.Project,
                    Description = "Built a plagiarism checker for a university academic, later used by several professors.",
                },
            ],
        },
        new SkillGroup
        {
            Title = "Data",
            Summary = "Schema changes on a live system, without downtime.",
            Skills =
            [
                new Skill
                {
                    Name = "SQL · Azure SQL Database",
                    Source = [Source.Airline],
                    Level = SkillLevel.Production,
                    Description = "Store and report on the airline's flights, passengers, freight and pilot records.",
                },
                new Skill
                {
                    Name = "LINQ · Linq2DB",
                    Source = [Source.Airline],
                    Level = SkillLevel.Production,
                    Description = "Pull data from the airline's database to produce reports, such as delays for each pilot.",
                },
                new Skill
                {
                    Name = "Database migrations",
                    Source = [Source.Airline],
                    Level = SkillLevel.Production,
                    Description = "Updated the airline's live database with no downtime for staff.",
                },
                new Skill
                {
                    Name = "Entity Framework Core · PostgreSQL",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description =
                        "Moved this site's content into a PostgreSQL database, with migrations applied automatically on every deploy.",
                },
            ],
        },
        new SkillGroup
        {
            Title = "Tooling & delivery",
            Summary = "How the code gets written, checked and shipped.",
            Skills =
            [
                new Skill
                {
                    Name = "Git · GitHub",
                    Source = [Source.ThisSite, Source.Airline],
                    Level = SkillLevel.Production,
                    Description = "Tracks every change I make, and let me work alongside 30+ students on a shared codebase.",
                },
                new Skill
                {
                    Name = "Vite · Prettier · dotnet format",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Keep my code fast to work on and consistently formatted.",
                },
                new Skill
                {
                    Name = "AWS Lightsail",
                    Source = [Source.CapstoneProject],
                    Level = SkillLevel.Project,
                    Description = "Put the plagiarism checker online so professors could use it on real student work.",
                },
                new Skill
                {
                    Name = "Azure App Service",
                    Source = [Source.ThisSite],
                    Level = SkillLevel.Project,
                    Description = "Hosts this website, with the React front end and .NET server deployed together.",
                },
                new Skill
                {
                    Name = "OpenSpec · AI-assisted planning",
                    Source = [Source.Airline],
                    Level = SkillLevel.Learning,
                    Description = "Learning a workflow where AI documents existing code, so new features are planned against it before any code is written.",
                },
            ],
        },
    ];
}
