using KayakMeetupService.Abstractions;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using Microsoft.Extensions.Logging;

namespace KayakMeetupService.Application.UseCases.UserUseCases;

public class GetUserUseCase
{
    private readonly ILogger<GetUserUseCase> _logger;
    private readonly IUserQuery _userQuery;

    public GetUserUseCase(ILogger<GetUserUseCase> logger, IUserQuery userQuery)
    {
        _logger = logger;
        _userQuery = userQuery;
    }

    public async Task<User> GetUserAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _userQuery.GetUserAsync(id, cancellationToken);
    }
}