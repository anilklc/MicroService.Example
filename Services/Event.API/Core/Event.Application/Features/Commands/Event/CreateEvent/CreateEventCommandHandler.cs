using Event.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Features.Commands.Event.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommandRequest, CreateEventCommandResponse>
    {
        private readonly IEventWriteRepository _eventWriteRepository;
        public CreateEventCommandHandler(IEventWriteRepository eventWriteRepository)
        {
            _eventWriteRepository = eventWriteRepository;
        }

        public async Task<CreateEventCommandResponse> Handle(CreateEventCommandRequest request, CancellationToken cancellationToken)
        {
            await _eventWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                Location = request.Location,
            });

            await _eventWriteRepository.SaveAsync();

            return new();
        }
    }
}
