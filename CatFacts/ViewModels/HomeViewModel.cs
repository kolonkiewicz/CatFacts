using CatFacts.Models;

namespace CatFacts.ViewModels;

public class HomeViewModel
{
    public CatFact? CurrentFact { get; set;}

    public List<CatFact> RecentFacts { get; set; } = new();
}