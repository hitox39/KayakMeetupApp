using UserLookupService.Abstractions;

namespace UserLookupService.Abstractions.Interfaces.IRepo;

public interface IUserRepository
{
    Task <User> AddAsync(User user, CancellationToken cancellationToken);
    Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    Task <User> UpdateUserAsync(User user, CancellationToken cancellationToken);

}


