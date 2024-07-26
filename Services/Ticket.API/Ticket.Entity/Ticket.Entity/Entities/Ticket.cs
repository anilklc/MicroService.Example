using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Entity.Entities
{
    public class Ticket : BaseEntity
    {
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        public decimal Price { get; set; }
    }
}
