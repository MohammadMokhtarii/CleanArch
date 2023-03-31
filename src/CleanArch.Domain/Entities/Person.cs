using CleanArch.Domain.Enums;

namespace CleanArch.Domain.Entities;
public class Person
{
    public int Id { get; set; }
    public string Firstname { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public PersonType PersonType { get; set; }
    public string PhoneNumber { get; set; }
}
