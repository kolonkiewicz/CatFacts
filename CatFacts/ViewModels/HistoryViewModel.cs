using CatFacts.Models;

namespace CatFacts.ViewModels;

public class HistoryViewModel
{
    public List<CatFact> Facts { get; set; } = new();

    public string? Keyword { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }

    public int PageSize { get; set; } = 5;
}