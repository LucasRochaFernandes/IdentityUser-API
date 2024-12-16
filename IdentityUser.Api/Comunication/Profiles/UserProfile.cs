using AutoMapper;
using IdentityUser.Api.Comunication.Requests;
using IdentityUser.Api.Database.Entities;

namespace IdentityUser.Api.Comunication.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserRequest, User>();
    }
}
