namespace Portfolio.Api.Models;

public record Scholarship(string Title, string Description);

public record EducationHighlight(
  string Eyebrow,
  string Title,
  string Description,
  string[] Tech
);

public record Education(
  int Id,
  string Degree,
  string University,
  string Location,
  string DateFrom,
  string DateTo,
  string Status,
  string? Summary,
  Scholarship? Scholarship,
  EducationHighlight[] Highlights,
  string[] Units
);
