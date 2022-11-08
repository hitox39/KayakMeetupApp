using Microsoft.Extensions.Logging;
using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Data.Models;

namespace UserLookupService.Domains
{
    public class UserUseCases
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserQuery _userQuery;
        private readonly ILogger _logger;


        public UserUseCases(IUserRepository userRepository, IUserQuery userQuery, ILogger logger)
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

        public async Task<User> UpdateUserAsync(User user, CancellationToken cancellationToken)
        {
            var updatedUser = await _userRepository.UpdateUserAsync(UserModelMapper.ToDatabase(user), cancellationToken);

            return updatedUser;
        }
    }
}
