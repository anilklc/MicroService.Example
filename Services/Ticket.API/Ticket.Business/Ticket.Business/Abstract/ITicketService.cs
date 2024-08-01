using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DataAccess.Abstract;
using Ticket.Entity.DTOs;
using Ticket.Entity.Entities;

namespace Ticket.Business.Abstract
{
    public interface ITicketService
    {
        IQueryable<Entity.Entities.Ticket> GetAll();
        Task<Entity.Entities.Ticket> GetById(string id);
        Task<bool> AddAsync(Entity.Entities.Ticket entity);
        Task<bool> Update(Entity.Entities.Ticket entity);
        Task<bool> RemoveAsync(string id);
        Task<TicketByEventIdDto> GetTicketByEventId(string eventId);
    }
}
