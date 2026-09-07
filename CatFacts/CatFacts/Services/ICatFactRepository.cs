using CatFacts.Models;
using CatFacts.ViewModels;

namespace CatFacts.Services;

public interface ICatFactRepository
{
    Task AddAsync(CatFact catFact);
    Task<List<CatFact>> GetAllAsync();
    Task<CatFact?> GetByIdAsync ( int id);

    Task<HistoryViewModel> GetHistoryAsync(
        string? Keyword,
        DateTime? from,
        DateTime? to,
        int page,
        int pageSize
    );

    Task<StatisticsViewModel?> GetStatisticsAsync();
}