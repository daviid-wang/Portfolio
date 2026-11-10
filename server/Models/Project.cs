using System.Text.Json.Serialization;

namespace Portfolio.Api.Models;

public class ProjectLink
{
    [JsonIgnore]
    public int Id { get; set; }
    public required string Label { get; set; }
    public required string Url { get; set; }
}

public class Project
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Eyebrow { get; set; }
    public required string Description { get; set; }
    public List<string> Tech { get; set; } = [];
    public List<ProjectLink> Links { get; set; } = [];
}
