using System;
using AutoMapper;
using TaskManagementSystem.DTOs.Users;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repositories.interfaces;
using TaskManagementSystem.Services.interfaces;

namespace TaskManagementSystem.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<UserResponseDto> CreateAsync(CreateUserDto dto)
    {
        // Check if email already exists
        var emailExists = await _repository.EmailExistsAsync(dto.Email);
        if (emailExists)
        {
            throw new InvalidOperationException($"Email '{dto.Email}' is already in use.");
        }

        var user = _mapper.Map<User>(dto);

        var created = await _repository.CreateAsync(user);

        return _mapper.Map<UserResponseDto>(created);
    }

    public async Task<UserResponseDto?> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        if (user == null)
            return null;

        return _mapper.Map<UserResponseDto>(user);
    }

    public async Task<List<UserResponseDto>> GetAllAsync()
    {
        var users = await _repository.GetAllAsync();

        return _mapper.Map<List<UserResponseDto>>(users);
    }
}
