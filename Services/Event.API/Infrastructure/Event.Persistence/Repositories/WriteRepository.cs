using Event.Application.Interfaces;
using Event.Domain.Common;
using Event.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly EventDbContext _context;

        public WriteRepository(EventDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T entity = await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
            EntityEntry entityEntry= Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
        

        public bool Update(T entity)
        {
            EntityEntry entityEntry =  Table.Update(entity);
            return entityEntry.State == EntityState.Modified;

        }
    }
}
