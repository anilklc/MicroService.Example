using Auth.Application.Features.Comman.User.CreateUser;
using Auth.Application.Features.Comman.User.Login;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]

        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest) =>  Ok(await _mediator.Send(createUserCommandRequest));


        [HttpPost("[action]")]

        public async Task<IActionResult> Login(LoginCommandRequest loginCommandRequest) => Ok(await _mediator.Send(loginCommandRequest));
        

    }
}
