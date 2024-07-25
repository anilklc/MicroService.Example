using Event.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Features.Commands.Event.RemoveEvent
{
    public class RemoveEventCommandHandler : IRequestHandler<RemoveEventCommandRequest, RemoveEventCommandResponse>
    {
        private readonly IEventWriteRepository _eventWriteRepository;
        public RemoveEventCommandHandler(IEventWriteRepository eventWriteRepository)
        {
            _eventWriteRepository = eventWriteRepository;
        }

        public async Task<RemoveEventCommandResponse> Handle(RemoveEventCommandRequest request, CancellationToken cancellationToken)
        {
            await _eventWriteRepository.RemoveAsync(request.Id);
            await _eventWriteRepository.SaveAsync();
            return new();
        }
    }
}
