using KayakMeetupService.Application.Models;
using KayakMeetupService.Application.UseCases.UserUseCases;
using Microsoft.AspNetCore.Mvc;

namespace KayakMeetupService.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly UserUseCases _userUseCase;

    public UserController(ILogger<UserController> logger, UserUseCases addUserUseCase)
    {
        _logger = logger;
        _userUseCase = addUserUseCase;
    }

    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById(
        [FromRoute] Guid id,
        CancellationToken cancellationToken
        )
    {

        var user = await _userUseCase.GetUserAsync(id, cancellationToken);

        if (user == null)
        {
            return NotFound($"User {id} could not be found.");
        }
        
        return Ok(user);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost]
    public async Task<IActionResult> AddUser(
        [FromServices] UserUseCases addUserUseCase,
        [FromBody] User user, 
        CancellationToken cancellationToken = default
        )
    {
        if (user == null)
        {
            return BadRequest("User cannot be empty.");
        }

        var createdUser = await addUserUseCase.AddUserAsync(user, cancellationToken);

        return Created($"User {createdUser.Id} has been created.", createdUser.Id);
    }


    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpPut]
    public async Task<IActionResult> UpdateUser(
        [FromBody] User user, 
        CancellationToken cancellationToken = default
        )
    {
        if (user == null)
        {
            return BadRequest("User cannot be empty.");
        }

        await _userUseCase.UpdateUserAsync(user, cancellationToken);

        return Ok();
    }
}

