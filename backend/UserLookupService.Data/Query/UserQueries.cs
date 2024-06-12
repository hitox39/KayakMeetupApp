using Microsoft.EntityFrameworkCore;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using KayakMeetupService.Data.Models;
using State = KayakMeetupService.Abstractions.Models.State;
using Boat = KayakMeetupService.Abstractions.Models.Boat;

namespace KayakMeetupService.Data;

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


    public async Task<IList<Abstractions.User>> GetAllUsersAsync(CancellationToken cancellationToken)
    {
        var users = await _dbContext.Users
            .ToListAsync(cancellationToken);

        return UserModelMapper.ToBusiness(users);
    }


    public async Task<IList<Abstractions.User>> GetUsersByZipCodeAsync(string zipCode, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Where(u => u.ZipCode == zipCode)
            .ToListAsync(cancellationToken);

        return UserModelMapper.ToBusiness(user);
    }


    public async Task<IList<Abstractions.User>> GetUsersByStateAsync(State state, CancellationToken cancellationToken)
    {
        var users = await _dbContext.Users
            .Where(u => u.State == state)
            .ToListAsync(cancellationToken);

        return UserModelMapper.ToBusiness(users);
    }

    public async Task<IList<Abstractions.User>> GetUsersByBoatAsync(Boat boat, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Where(u => u.Boat == boat)
            .SingleAsync(cancellationToken);

        return UserModelMapper.ToBusiness(user);
    }
}


