using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserIdentity.Api.Comunication.Requests;
using UserIdentity.Api.Database.Entities;

namespace UserIdentity.Api.Services;

public class RegisterUserService
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public RegisterUserService(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<IdentityResult> Execute(RegisterUserRequest request)
    {
        var entity = _mapper.Map<User>(request);
        var result = await _userManager.CreateAsync(entity, request.Password);
        return result;
    }
}
