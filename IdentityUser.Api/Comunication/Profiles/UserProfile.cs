using AutoMapper;
using UserIdentity.Api.Comunication.Requests;
using UserIdentity.Api.Database.Entities;

namespace UserIdentity.Api.Comunication.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserRequest, User>();
    }
}
