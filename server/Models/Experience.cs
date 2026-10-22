namespace Portfolio.Api.Models;

public record Experience(
  int Id, 
  string Role, 
  string[] Description, 
  string[] Tech, 
  string DateFrom, 
  string? DateTo, 
  string Company, 
  string Location
);
