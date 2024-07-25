using Event.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Features.Queries.Event.GetAllEvent
{
    public class GetAllEventQueryHandler : IRequestHandler<GetAllEventQueryRequest, GetAllEventQueryResponse>
    {
        private readonly IEventReadRepository _eventReadRepository;
        public GetAllEventQueryHandler(IEventReadRepository eventReadRepository)
        {
            _eventReadRepository = eventReadRepository;
        }

        public async Task<GetAllEventQueryResponse> Handle(GetAllEventQueryRequest request, CancellationToken cancellationToken)
        {
            var events =  _eventReadRepository.GetAll().ToList();
            return new()
            {
                Events = events,
            };
        }
    }
}
