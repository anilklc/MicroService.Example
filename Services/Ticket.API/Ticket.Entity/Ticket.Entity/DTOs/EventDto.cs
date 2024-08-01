using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Entity.Entities;

namespace Ticket.Entity.DTOs
{
    public class EventDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
