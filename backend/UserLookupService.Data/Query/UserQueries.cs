using Microsoft.EntityFrameworkCore;
using UserLookupService.Abstractions;
using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Models;
using UserLookupService.Data.Models;
using Boat = UserLookupService.Data.Models.Boat;

namespace UserLookupService.Data;

public class UserQueries : IUserQuery
{
    private readonly MainContext _dbContext;
    public UserQueries(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

   
    public async Task<Abstractions.User> GetUserAsync(Guid id, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Where(u => u.Id == id)
            .SingleOrDefaultAsync(cancellationToken)
            ?? throw new ArgumentNullException(nameof(id));

        return UserModelMapper.ToBusiness(user);
    }

   
    public async Task<IList<Abstractions.User>> GetUsersAsync(CancellationToken cancellationToken)
    {
        var users = await _dbContext.Users
            .ToListAsync(cancellationToken);

        return UserModelMapper.ToBusiness(users);
    }

    
    public async Task<IList<Abstractions.User>> GetUsersAsync(string zipCode, CancellationToken cancellationToken)
    {
        var users = await _dbContext.Users
            .Where(u => u.ZipCode == zipCode)
            .ToListAsync(cancellationToken);

        return UserModelMapper.ToBusiness(users);
    }


    public async Task<IList<Abstractions.User>> GetUsersAsync(State state, CancellationToken cancellationToken)
    {
        var users = await _dbContext.Users
            .Where(u => u.State == state)
            .ToListAsync(cancellationToken);

        return UserModelMapper.ToBusiness(users);
    }

    public async Task<Abstractions.User> GetUserAsync(Boat boat, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Where(u => u.Boat == boat)
            .SingleAsync(cancellationToken);

        return UserModelMapper.ToBusiness(user);
    }
}


