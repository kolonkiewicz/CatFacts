using CatFacts.Models;

namespace CatFacts.Services;

public interface ICatFactRepository
{
    Task AddAsync(CatFact catFact);
    Task<List<CatFact>> GetAllAsync();
    Task<CatFact?> GetByIdAsync ( int id);
}