namespace Portfolio.Api.Models;

public record Experience(
  int Id, 
  string Role, 
  string[] Description, 
  string[] Tech, 
  DateOnly DateFrom, 
  DateOnly? DateTo, 
  string Company, 
  string Location
);
