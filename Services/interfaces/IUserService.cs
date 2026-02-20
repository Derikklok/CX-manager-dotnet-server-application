using System;
using TaskManagementSystem.DTOs.Users;

namespace TaskManagementSystem.Services.interfaces;

public interface IUserService
{
    Task<UserResponseDto> CreateAsync(CreateUserDto dto);
    Task<UserResponseDto?> GetByIdAsync(Guid id);
    Task<List<UserResponseDto>> GetAllAsync();
}
