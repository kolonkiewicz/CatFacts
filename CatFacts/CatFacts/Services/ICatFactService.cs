using CatFacts.Models;

namespace CatFacts.Services;

public interface ICatFactService
{
    Task<CatFact> GetRandomFactAsync();
}