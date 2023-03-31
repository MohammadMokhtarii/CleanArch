using CleanArch.Domain.Base;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Persistence;

public class PersonRepo : IPersonRepo
{
    private readonly DbSet<Person> _persons;
    public PersonRepo(ApplicationDbContext dbContext) => _persons = dbContext.Set<Person>();


    public void Add(Person person)
    {
        _persons.Add(person);
    }
}
