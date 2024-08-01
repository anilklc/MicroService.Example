using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ticket.Entity.Entities;

namespace Ticket.DataAccess.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(string id);
        Task<bool> AddAsync(T entity);
        bool Update(T entity);
        Task<bool> RemoveAsync(string id);
        Task<int> SaveAsync();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

    }
}
