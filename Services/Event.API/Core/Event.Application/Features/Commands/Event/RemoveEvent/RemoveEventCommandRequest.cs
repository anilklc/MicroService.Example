using MediatR;

namespace Event.Application.Features.Commands.Event.RemoveEvent
{
    public class RemoveEventCommandRequest : IRequest<RemoveEventCommandResponse>
    {
        public string Id { get; set; }
    }
}