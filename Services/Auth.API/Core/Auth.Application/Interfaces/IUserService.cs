using Auth.Application.DTOs;

namespace Auth.Application.Interfaces
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser user);

    }
}
