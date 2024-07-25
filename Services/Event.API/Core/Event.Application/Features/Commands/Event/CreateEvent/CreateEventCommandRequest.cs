using MediatR;

namespace Event.Application.Features.Commands.Event.CreateEvent
{
    public class CreateEventCommandRequest : IRequest<CreateEventCommandResponse>
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}