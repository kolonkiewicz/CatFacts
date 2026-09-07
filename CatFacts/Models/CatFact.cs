namespace CatFacts.Models;

public class CatFact
{
    public int Id { get; set; }

    public string Fact { get; set; } = string.Empty;

    public int Length { get; set; }

    public DateTime CreatedAt { get; set; }
}