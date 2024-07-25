using Event.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Features.Queries.Event.GetByIdEvent
{
    public class GetByIdEventQueryHandler : IRequestHandler<GetByIdEventQueryRequest, GetByIdEventQueryResponse>
    {
        private readonly IEventReadRepository _eventReadRepository;

        public GetByIdEventQueryHandler(IEventReadRepository eventReadRepository)
        {
            _eventReadRepository = eventReadRepository;
        }

        public async Task<GetByIdEventQueryResponse> Handle(GetByIdEventQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _eventReadRepository.GetById(request.Id);

           return  result == null ? throw new Exception("Etkinlik bulunamadı") : 
            new()
            {
                Id = result.Id.ToString(),
                Name = result.Name,
                Location = result.Location,
                CreatedDate = result.CreatedDate,
            };

        }
    }
}
