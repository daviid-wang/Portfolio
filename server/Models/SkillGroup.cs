using System.Text.Json.Serialization;

namespace Portfolio.Api.Models;

public class SkillGroup
{
    [JsonIgnore]
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public List<Skill> Skills { get; set; } = [];
}
