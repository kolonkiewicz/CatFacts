using CatFacts.Data;
using CatFacts.Models;
using Microsoft.EntityFrameworkCore;
using CatFacts.ViewModels;

namespace CatFacts.Services;

public class CatFactRepository : ICatFactRepository
{
    private readonly CatFactsDbContext _context;

    public CatFactRepository( CatFactsDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync( CatFact catFact)
    {
        await _context.CatFacts.AddAsync(catFact);
        await _context.SaveChangesAsync();
    }

    public async Task<List<CatFact>> GetAllAsync()
    {
        return await _context.CatFacts
            .OrderByDescending(c => c.CreatedAt)
            .ToListAsync();
    }

    public async Task<CatFact?> GetByIdAsync( int id)
    {
        return await _context.CatFacts
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<HistoryViewModel> GetHistoryAsync(
        string? keyword,
        DateTime? from,
        DateTime? to,
        int page,
        int pageSize)
    {
        var query = _context.CatFacts.AsQueryable();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            query = query.Where(c =>
                c.Fact.Contains(keyword));
        }

        if (from.HasValue)
        {
            query = query.Where(c =>
                c.CreatedAt >= from.Value);
        }

        if (to.HasValue)
        {
            var toDate = to.Value.Date.AddDays(1);

            query = query.Where(c =>
                c.CreatedAt < toDate);
        }

        var totalCount = await query.CountAsync();

        var totalPages = (int)Math.Ceiling(
            totalCount / (double)pageSize);

        if (totalPages == 0)
        {
            totalPages = 1;
        }

        page = Math.Max(1, Math.Min(page, totalPages));

        var facts = await query
            .OrderByDescending(c => c.CreatedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new HistoryViewModel
        {
            Facts = facts,
            Keyword = keyword,
            From = from,
            To = to,
            CurrentPage = page,
            TotalPages = totalPages,
            PageSize = pageSize
        };
    }

    public async Task<StatisticsViewModel?> GetStatisticsAsync()
    {
        var facts = await _context.CatFacts
            .AsNoTracking()
            .ToListAsync();

        if (facts.Count == 0)
        {
            return null;
        }

        var lengths = facts
            .Select(f => f.Length)
            .ToList();

        var shortest = facts
            .OrderBy(f => f.Length)
            .First();

        var longest = facts
            .OrderByDescending(f => f.Length)
            .First();

        var distribution = new List<LengthBucketViewModel>
        {
            new()
            {
                Label = "0–50",
                Count = facts.Count(f => f.Length >= 0 && f.Length <= 50)
            },
            new()
            {
                Label = "51–75",
                Count = facts.Count(f => f.Length >= 51 && f.Length <= 75)
            },
            new()
            {
                Label = "76–100",
                Count = facts.Count(f => f.Length >= 76 && f.Length <= 100)
            },
            new()
            {
                Label = "101–125",
                Count = facts.Count(f => f.Length >= 101 && f.Length <= 125)
            },
            new()
            {
                Label = "126+",
                Count = facts.Count(f => f.Length >= 126)
            }
        };

        return new StatisticsViewModel
        {
            TotalFacts = facts.Count,

            AverageLength = (int)Math.Round(
                lengths.Average()),

            ShortestLength = shortest.Length,
            ShortestFact = shortest.Fact,

            LongestLength = longest.Length,
            LongestFact = longest.Fact,

            Distribution = distribution
        };
    }
}