namespace Portfolio.Api.Models;

public record ProjectLink(string Label, string Url);

public record Project(
  int Id, 
  string Title,
  string Eyebrow,
  string Description,
  string[] Tech,
  ProjectLink[] Links
);