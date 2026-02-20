using System;
using AutoMapper;
using TaskManagementSystem.DTOs.Users;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>();
        CreateMap<User, UserResponseDto>();
    }
}
