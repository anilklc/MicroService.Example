using Event.Application.Interfaces;
using Event.Domain.Entities;
using Event.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Persistence.Repositories.Event
{
    public class EventReadRepository : ReadRepository<Domain.Entities.Event>,IEventReadRepository
    {
        public EventReadRepository(EventDbContext context) : base(context)
        {
        }
    }
}
