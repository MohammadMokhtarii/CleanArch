using CleanArch.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.Base;

public record AddPersonDto([Required, MaxLength(100)] string Firstname,
                           [Required, MaxLength(100)] string Lastname,
                           [Required] PersonType PersonType,
                           [Required, StringLength(11, MinimumLength = 11)] string PhoneNumber);
