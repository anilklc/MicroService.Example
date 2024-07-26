using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DataAccess.Abstract;
using Ticket.DataAccess.Context;
using Ticket.Entity.Entities;

namespace Ticket.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly TicketDbContext _context;
        public GenericRepository(TicketDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table.AsNoTracking();
        public async Task<T> GetById(string id) => await Table.FirstOrDefaultAsync(s => s.Id == Guid.Parse(id));

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T entity = await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
            EntityEntry entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();


        public bool Update(T entity)
        {
            EntityEntry entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;

        }
    }
}
