using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Entity.Entities;

namespace Ticket.Entity.DTOs
{
    public class TicketByEventIdDto
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public DateTime EventCreatedDate { get; set; }
        public List<Entities.Ticket> Tickets { get; set; }
    }
}
