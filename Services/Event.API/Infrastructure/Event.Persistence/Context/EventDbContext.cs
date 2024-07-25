using Event.Domain.Common;
using Event.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Persistence.Context
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Domain.Entities.Event> Events { get; set; }

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
