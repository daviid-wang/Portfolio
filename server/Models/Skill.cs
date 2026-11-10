using System.Text.Json.Serialization;
namespace Portfolio.Api.Models;

[JsonConverter(typeof(JsonStringEnumConverter<SkillLevel>))]
public enum SkillLevel
{
    [JsonStringEnumMemberName("production")]
    Production,

    [JsonStringEnumMemberName("project")]
    Project,

    [JsonStringEnumMemberName("learning")]
    Learning
}

[JsonConverter(typeof(JsonStringEnumConverter<Source>))]
public enum Source
{
    [JsonStringEnumMemberName("this-site")]
    ThisSite,

    [JsonStringEnumMemberName("coders-for-causes")]
    CodersForCauses,

    [JsonStringEnumMemberName("airline")]
    Airline,

    [JsonStringEnumMemberName("capstone-project")]
    CapstoneProject
}

public class Skill
{
    [JsonIgnore]
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<Source> Source { get; set; } = [];
    public SkillLevel Level { get; set; }
    public required string Description { get; set; }
}