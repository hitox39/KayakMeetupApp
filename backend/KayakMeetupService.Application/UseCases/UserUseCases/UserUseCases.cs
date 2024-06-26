using AutoMapper;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Application.Models;
using Microsoft.Extensions.Logging;

namespace KayakMeetupService.Application.UseCases.UserUseCases;

public class UserUseCases
{
    private readonly IUserRepository _userRepository;
    private readonly IUserQuery _userQuery;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public UserUseCases(
        IUserRepository userRepository,
        IMapper mapper,
        ILogger logger,
        IUserQuery userQuery
        )
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _logger = logger;
        _userQuery = userQuery;
    }

    public async Task<User> AddUserAsync(User user, CancellationToken cancellationToken)
    {
        try
        {
            var dataUser = _mapper.Map<Data.Models.User>(user);

            _logger.LogInformation("Attempting to add user: [{user.Id}]", user.Id);
            await _userRepository.AddUserAsync(dataUser, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError($"An error ${ex.Message} occured while trying to add ${user.Id}.");
            throw new Exception($"An error ${ex.Message} occured while trying to add ${user.Id}.");
        }

        return user;
    }

    public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Attempting to delete user: [{userId}]", userId);
        await _userRepository.DeleteUserAsync(userId, cancellationToken);
    }

    public async Task<User> GetUserAsync(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Attempting to get user: [{id}]", id);
            var user = await _userQuery.GetUserAsync(id, cancellationToken);

            var appUser = _mapper.Map<User>(user);

            return appUser;

        }
        catch (Exception ex)
        {
            _logger.LogError($"An error ${ex.Message} occured while trying to delete ${id}.");
            throw new Exception($"An error ${ex.Message} occured while trying to delete ${id}.");
        }
    }

    public async Task UpdateUserAsync(User user, CancellationToken cancellationToken)
    {
        try
        {
            var dataUser = _mapper.Map<Data.Models.User>(user);
            _logger.LogInformation("Attempting to update user: [{user.Id}]", user.Id);
            var updatedUser = await _userRepository.UpdateUserAsync(dataUser, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError($"An error ${ex.Message} occured while trying to update ${user.Id}.");
            throw new Exception($"An error ${ex.Message} occured while trying to update ${user.Id}.");
        }
    }
}
