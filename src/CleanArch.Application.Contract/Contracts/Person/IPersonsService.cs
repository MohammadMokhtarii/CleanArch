namespace CleanArch.Application;

public interface IPersonsService
{
    Task<int> AddAsync(AddPersonDto item, CancellationToken cancellationToken = default);
}
