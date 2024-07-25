using Event.Domain.Entities;

namespace Event.Application.Interfaces
{
    public interface IEventWriteRepository : IWriteRepository<Domain.Entities.Event>
    {
    }
}
