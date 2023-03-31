using CleanArch.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application;

public record AddPersonDto([Required, MaxLength(100)] string Firstname,
                           [Required, MaxLength(100)] string Lastname,
                           [Required] PersonType PersonType,
                           [Required, StringLength(11, MinimumLength = 11)] string PhoneNumber);
