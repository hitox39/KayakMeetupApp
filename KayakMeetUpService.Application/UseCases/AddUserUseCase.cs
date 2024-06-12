using KayakMeetupService.Abstractions;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Application.Models;

namespace KayakMeetupService.Application.UseCases;

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
