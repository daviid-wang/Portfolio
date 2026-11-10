using System.Text.Json.Serialization;

namespace Portfolio.Api.Models;

public class Scholarship
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}

public class EducationHighlight
{
    [JsonIgnore]
    public int Id { get; set; }
    public required string Eyebrow { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public List<string> Tech { get; set; } = [];
}

public class Education
{
    public int Id { get; set; }
    public required string Degree { get; set; }
    public required string University { get; set; }
    public required string Location { get; set; }
    public required string DateFrom { get; set; }
    public required string DateTo { get; set; }
    public required string Status { get; set; }
    public string? Summary { get; set; }
    public Scholarship? Scholarship { get; set; }
    public List<EducationHighlight> Highlights { get; set; } = [];
    public List<string> Units { get; set; } = [];
}
