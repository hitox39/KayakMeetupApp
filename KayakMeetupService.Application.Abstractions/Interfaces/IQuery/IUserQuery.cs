using KayakMeetupService.Data.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IQuery;

public interface IUserQuery
{
    Task<User> GetUserAsync(Guid id, CancellationToken cancellationToken);
    Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken);
    Task<IList<User>> GetUsersByStateAsync(State state, CancellationToken cancellationToken);
    Task<IList<User>> GetUsersByZipCodeAsync(string zipCode, CancellationToken cancellationToken);
    Task<IList<User>> GetUsersByBoatAsync(Boat boat, CancellationToken cancellationToken);
}