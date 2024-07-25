using Event.Application.Interfaces;
using Event.Persistence.Context;

namespace Event.Persistence.Repositories.Event
{
    public class EventWriteRepository : WriteRepository<Domain.Entities.Event>, IEventWriteRepository
    {
        public EventWriteRepository(EventDbContext context) : base(context)
        {
        }
    }
}
