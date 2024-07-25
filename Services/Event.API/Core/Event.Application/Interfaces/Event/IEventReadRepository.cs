using Event.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Interfaces
{
    public interface IEventReadRepository : IReadRepository<Domain.Entities.Event>
    {
    }
}
