using CleanArch.Domain.Base;

namespace CleanArch.Application.Base;

public class PersonsService : IPersonsService
{
    private readonly IUnitOfWork _uow;
    private readonly ISMSAdaptor _SMSAdaptor;

    public PersonsService(IUnitOfWork uow, ISMSAdaptor sMSAdaptor) => (_uow, _SMSAdaptor) = (uow, sMSAdaptor);

    public async Task<int> AddAsync(AddPersonDto item, CancellationToken cancellationToken = default)
    {
        Person model = new()
        {
            Firstname = item.Firstname,
            LastName = item.Lastname,
            PersonType = item.PersonType,
            PhoneNumber = item.PhoneNumber,
        };

        _uow.PersonRepo.Add(model);

        var dbResult = await _uow.SaveChangesAsync(cancellationToken);
        if (!dbResult)
            return 0;

        await _SMSAdaptor.SendAsync(item.PhoneNumber, $"Welcome Back Dear {model.Firstname} {model.LastName}!", cancellationToken);

        return model.Id;
    }
}
