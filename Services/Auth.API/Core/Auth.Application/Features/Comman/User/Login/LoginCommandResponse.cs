using Auth.Application.DTOs;

namespace Auth.Application.Features.Comman.User.Login
{
    public class LoginCommandResponse
    {
    }
    public class LoginSuccessCommandResponse : LoginCommandResponse
    {
        public Token Token { get; set; }
    }
    public class LoginErrorCommandResponse : LoginCommandResponse
    {
        public string Message { get; set; }
    }
}