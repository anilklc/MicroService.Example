using MediatR;

namespace Event.Application.Features.Queries.Event.GetByIdEvent
{
    public class GetByIdEventQueryRequest : IRequest<GetByIdEventQueryResponse>
    {
        public string Id { get; set; }
    }
}