using System;

namespace TaskManagementSystem.DTOs.Users;

public class CreateUserDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
