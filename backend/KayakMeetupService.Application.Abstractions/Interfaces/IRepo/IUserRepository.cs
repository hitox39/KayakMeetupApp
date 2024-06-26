
using KayakMeetupService.Data.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IRepo;

public interface IUserRepository
{
    Task<Guid> AddUserAsync(User user, CancellationToken cancellationToken);
    Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    Task<User> UpdateUserAsync(User user, CancellationToken cancellationToken);
}
