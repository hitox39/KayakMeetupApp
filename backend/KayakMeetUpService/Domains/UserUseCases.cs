using Microsoft.Extensions.Logging;
using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Data.Models;

namespace KayakMeetUpService.Domains
{
    public class UserUseCases
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserQuery _userQuery;
        private readonly ILogger<UserUseCases> _logger;


        public UserUseCases(IUserRepository userRepository, IUserQuery userQuery, ILogger<UserUseCases> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
            _userQuery = userQuery;
        }

        public async Task<Abstractions.User> AddUserAsync(Abstractions.User user, CancellationToken cancellationToken)
        {
            user.Id = Guid.NewGuid();

            await _userRepository.AddAsync(user, cancellationToken);

            return user;
        }

        public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Attempting to delete user: [{userId}]", userId);
            await _userRepository.DeleteUserAsync(userId, cancellationToken);
        }

        public async Task<Abstractions.User> GetUserAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _userQuery.GetUserAsync(id, cancellationToken);
        }

        public async Task UpdateUserAsync(Abstractions.User user, CancellationToken cancellationToken)
        {
            await _userRepository.UpdateUserAsync(user, cancellationToken);

        }
    }
}
