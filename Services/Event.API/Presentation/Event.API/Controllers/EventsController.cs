using Event.Application.Features.Commands.Event.CreateEvent;
using Event.Application.Features.Commands.Event.RemoveEvent;
using Event.Application.Features.Commands.Event.UpdateEvent;
using Event.Application.Features.Queries.Event.GetAllEvent;
using Event.Application.Features.Queries.Event.GetByIdEvent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Event.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEvents()
            => Ok(await _mediator.Send(new GetAllEventQueryRequest()));


        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetByIdEvent([FromRoute] GetByIdEventQueryRequest request)
            => Ok(await _mediator.Send(request));


        [HttpPost("[action]")]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventCommandRequest request)
            => Ok(await _mediator.Send(request));

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateEvent([FromBody] UpdateEventCommandRequest request)
            => Ok(await _mediator.Send(request));

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> RemoveEvent([FromRoute] RemoveEventCommandRequest request)
            => Ok(await _mediator.Send(request));

    }
}
