namespace Portfolio.Api.Models;

public record SkillGroup(
  string Title,
  string Summary,
  Skill[] Skills
);