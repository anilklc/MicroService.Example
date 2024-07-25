using Event.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Domain.Entities
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
