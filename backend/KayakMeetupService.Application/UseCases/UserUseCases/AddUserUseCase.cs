﻿using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Application.Models.User;

namespace KayakMeetupService.Application.UseCases.UserUseCases;

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
