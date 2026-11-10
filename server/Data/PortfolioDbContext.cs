using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Models;

namespace Portfolio.Api.Data;

public class PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : DbContext(options)
{
    public DbSet<Experience> Experience => Set<Experience>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Education> Education => Set<Education>();
    public DbSet<SkillGroup> SkillGroups => Set<SkillGroup>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Education>().OwnsOne(e => e.Scholarship);
    }
}
