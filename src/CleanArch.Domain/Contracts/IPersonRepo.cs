using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Contracts;

public interface IPersonRepo
{
    void Add(Person person);
}
