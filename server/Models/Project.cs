namespace Portfolio.Api.Models;

public record Project(
  int Id, 
  string Title,
  string Eyebrow,
  string Description,
  string[] Tech,
  string[] Url
);