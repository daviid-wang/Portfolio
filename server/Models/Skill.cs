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

public record Skill(
  string Name,
  Source[] Source,
  SkillLevel Level,
  string Description
);