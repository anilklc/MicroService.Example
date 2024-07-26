using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Entity.Entities;

namespace Ticket.DataAccess.Context
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Entity.Entities.Ticket> Tickets { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                var _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow,
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
