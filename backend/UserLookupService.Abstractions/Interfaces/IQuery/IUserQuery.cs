using UserLookupService.Abstractions;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery;

public interface IUserQuery
{
    Task<User> GetUserAsync(Guid id, CancellationToken cancellationToken);
    Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken);
    Task<IList<User>> GetUsersByStateAsync(State state, CancellationToken cancellationToken);
    Task<IList<User>> GetUsersByZipCodeAsync(string zipCode, CancellationToken cancellationToken);

}