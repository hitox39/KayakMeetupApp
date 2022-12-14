using KayakMeetUpService.Abstractions;

namespace KayakMeetUpService.Abstractions.Interfaces.IRepo;

public interface IUserRepository
{
    Task AddAsync(User user, CancellationToken cancellationToken);
    Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    Task UpdateUserAsync(User user, CancellationToken cancellationToken);

}


