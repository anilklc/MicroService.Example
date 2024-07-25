using Event.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application.Interfaces
{
    public interface IReadRepository<T> where T : BaseEntity
    {
         IQueryable<T> GetAll();
         Task<T> GetById(string Id);
    }
}
