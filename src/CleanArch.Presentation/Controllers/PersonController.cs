using CleanArch.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Presentation.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PersonController : ControllerBase
{
    private readonly IPersonsService _personsService;

    public PersonController(IPersonsService personsService) => _personsService = personsService;

    [HttpPost]
    public async Task<IActionResult> AddAsync(AddPersonDto item, CancellationToken cancellationToken)
        => Ok(await _personsService.AddAsync(item, cancellationToken));
}
