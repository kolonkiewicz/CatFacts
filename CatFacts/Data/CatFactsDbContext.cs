using CatFacts.Data.Seed;
using CatFacts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CatFacts.Data;

public class CatFactsDbContext : DbContext
{
    public CatFactsDbContext( DbContextOptions<CatFactsDbContext> options )
        : base( options )
    {
        
    }

    public DbSet<CatFact> CatFacts { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        CatFactSeedData.Seed(modelBuilder);
    }
}