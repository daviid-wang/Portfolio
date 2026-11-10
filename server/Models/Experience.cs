namespace Portfolio.Api.Models;

public class Experience
{
    public int Id { get; set; }
    public required string Role { get; set; }
    public List<string> Description { get; set; } = [];
    public List<string> Tech { get; set; } = [];
    public required string DateFrom { get; set; }
    public string? DateTo { get; set; }
    public required string Company { get; set; }
    public required string Location { get; set; }
}
