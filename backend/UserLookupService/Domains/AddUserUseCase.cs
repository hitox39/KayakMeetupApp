using UserLookupService.Abstractions;
using UserLookupService.Abstractions.Interfaces.IRepo;

namespace UserLookupService.Domains;

public class AddUserUseCase
{
    private readonly IUserRepository _userRepository;
    public AddUserUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> AddUserAsync(User user, CancellationToken cancellationToken)
    {
        user.Id = Guid.NewGuid();

        await _userRepository.AddAsync(user, cancellationToken);

        return user;
    }
}
