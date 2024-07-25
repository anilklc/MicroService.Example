using Event.Application.Interfaces;
using Event.Domain.Common;
using Event.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly EventDbContext _context;

        public ReadRepository(EventDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll() => Table.AsNoTracking();
        public async Task<T> GetById(string id) => await Table.FirstOrDefaultAsync(s => s.Id == Guid.Parse(id));

    }
}
