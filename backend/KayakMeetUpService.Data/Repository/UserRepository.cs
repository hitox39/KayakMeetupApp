using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Data.Models;


namespace KayakMeetUpService.Data;

public class UserRepository : IUserRepository
{
    private readonly MainContext _dbContext;
    private readonly IUserQuery _userQueries;



    public UserRepository(MainContext dbContext, IUserQuery userQueries)
    {
        _dbContext = dbContext;
        _userQueries = userQueries;
    }

    public async Task AddAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        await _dbContext.Users.AddAsync(UserModelMapper.ToDatabase(user), cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteUserAsync(Guid id, CancellationToken cancellationToken)
    {
         _dbContext.Users.Remove(new User
        {
            Id = id
        });
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateUserAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        var userUpdate = await _userQueries.GetUserAsync(user.Id, cancellationToken);
       
        userUpdate.State = user.State;
        userUpdate.DateOfBirth = user.DateOfBirth;
        userUpdate.State = user.State;
        userUpdate.Address = user.Address;
        userUpdate.Email = user.Email;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}


