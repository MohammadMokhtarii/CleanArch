using CleanArch.Domain.Contracts;

namespace CleanArch.Application;

public interface IUnitOfWork
{
    public IPersonRepo PersonRepo { get; }
    public Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
}
