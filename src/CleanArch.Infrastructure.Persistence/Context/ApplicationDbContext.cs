using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
