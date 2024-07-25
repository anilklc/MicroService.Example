using Event.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Features.Commands.Event.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommandRequest, UpdateEventCommandResponse>
    {
        private readonly IEventReadRepository _eventReadRepository;
        private readonly IEventWriteRepository _eventWriteRepository;
        public UpdateEventCommandHandler(IEventReadRepository eventReadRepository, IEventWriteRepository eventWriteRepository)
        {
            _eventReadRepository = eventReadRepository;
            _eventWriteRepository = eventWriteRepository;
        }

        public async Task<UpdateEventCommandResponse> Handle(UpdateEventCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _eventReadRepository.GetById(request.Id);
            result.Name = request.Name;
            result.Location = request.Location;
            await _eventWriteRepository.SaveAsync();
            return new();
        }
    }
}
