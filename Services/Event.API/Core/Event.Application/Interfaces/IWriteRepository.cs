using Event.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Interfaces
{
    public interface IWriteRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        bool Update(T entity);
        Task<bool> RemoveAsync(string id);
        Task<int> SaveAsync();

    }
}
