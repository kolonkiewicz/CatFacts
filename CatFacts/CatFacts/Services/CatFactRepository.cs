using CatFacts.Data;
using CatFacts.Models;
using Microsoft.EntityFrameworkCore;

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
}