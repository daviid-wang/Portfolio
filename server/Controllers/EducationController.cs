using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Models;

namespace Portfolio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EducationController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Education>> Get()
    {
        var education = new[]
        {
      new Education(
          1,
          "Bachelor of Science (Software Engineering)",
          "University of Western Australia",
          "Perth, WA",
          "Feb 2021",
          "Nov 2023",
          "Completed",
          null,
          new Scholarship(
              "UWA Engineering Scholarship",
              "Awarded for academic merit and held for the full duration of the degree."
          ),
          [
              new EducationHighlight(
                  "CAPSTONE · JUL - NOV 2023",
                  "Plagiarism Detection Tool",
                  "Built for a UWA Associate Professor of Psychology with a team of six. I developed the Word metadata analysis that flags suspicious edit histories. MVP delivered about six weeks early, then I deployed the application on AWS Lightsail with the time remaining.",
                  ["JavaScript", "Python", "Flask", "AWS Lightsail"]
              ),
              new EducationHighlight(
                  "CODERS FOR CAUSES · DEC 2022 - MAR 2023",
                  "Not-for-profit websites",
                  "Responsive pages from Figma designs for the WA Debating League, Elucidate and Pets of Older Persons, in a 30+ student team. Selected for a paid continuation role with the Debating League.",
                  ["Vue.js", "Tailwind CSS", "Figma"]
              ),
              new EducationHighlight(
                "STUDY TOUR · SEOUL · NOV - DEC 2022",
                "Cyber security study tour, Korea",
                "Three weeks in Seoul as part of the penetration testing unit, meeting students from Korea University and Seoul Women's University, hearing their capstone project presentations and discussing what we'd covered in class. I also gave a presentation to Korea University students on reverse engineering as a security vulnerability.",
                ["Public presentation", "Reverse engineering", "Ghidra", "Kali Linux"]
            )
          ],
          ["Data Structures and Algorithms", "Agile Web Development", "Digital Embedded Systems", "Systems Programming", "Computer Networks", "Professional Computing", "Penetration Testing"]
      ),
      new Education(
        2,
        "Master of Professional Engineering (Software Engineering)",
        "University of Western Australia",
        "Perth, WA",
        "Feb 2024",
        "Nov 2024",
        "One year completed",
        "Completed one year of postgraduate study, then left the program to pursue professional software development.",
        new Scholarship(
              "UWA Engineering Scholarship",
              "Awarded for academic merit."
        ),
        [],
        ["Software Requirements and Design", "Software Testing and Quality Assurance", "Mobile Robots", "Artificial Intelligence and Adaptive Systems"]
      )
    };

        return Ok(education);
    }
}