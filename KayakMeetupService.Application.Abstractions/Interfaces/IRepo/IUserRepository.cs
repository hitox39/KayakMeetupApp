using KayakMeetupService.Data.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IRepo;

public interface IUserRepository
{
    Task AddUserAsync(User user, CancellationToken cancellationToken);
    Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    Task UpdateUserAsync(User user, CancellationToken cancellationToken);
}

