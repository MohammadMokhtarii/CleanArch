using CleanArch.Application;

namespace CleanArch.Infrastructure.Persistence;

public partial class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    public UnitOfWork(ApplicationDbContext dbContext) => _dbContext = dbContext;
    public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }

    }
}
