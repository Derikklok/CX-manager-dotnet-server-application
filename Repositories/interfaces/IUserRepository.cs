using System;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Repositories.interfaces;

public interface IUserRepository
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByIdAsync(Guid id);
    Task<List<User>> GetAllAsync();
}
