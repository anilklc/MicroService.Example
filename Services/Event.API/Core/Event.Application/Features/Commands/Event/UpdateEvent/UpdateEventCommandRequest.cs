using MediatR;

namespace Event.Application.Features.Commands.Event.UpdateEvent
{
    public class UpdateEventCommandRequest : IRequest<UpdateEventCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}