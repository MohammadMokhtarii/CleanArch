namespace CleanArch.Application.Base;

public interface IPersonsService
{
    Task<int> AddAsync(AddPersonDto item, CancellationToken cancellationToken = default);
}
