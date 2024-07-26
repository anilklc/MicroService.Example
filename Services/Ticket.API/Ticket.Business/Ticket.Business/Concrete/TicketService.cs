using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Business.Abstract;
using Ticket.DataAccess.Abstract;
using Ticket.Entity.Entities;

namespace Ticket.Business.Concrete
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Entity.Entities.Ticket> _repository;

        public TicketService(DataAccess.Abstract.IRepository<Entity.Entities.Ticket> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Entity.Entities.Ticket entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveAsync();
            return true;
        }

        public IQueryable<Entity.Entities.Ticket> GetAll() =>_repository.GetAll();


        public Task<Entity.Entities.Ticket> GetById(string id) => _repository.GetById(id);


        public async Task<bool> RemoveAsync(string id) 
        {
            var result = await _repository.RemoveAsync(id);
            if (result == null )
                throw new Exception("Bilet bulunamadı");

            await _repository.SaveAsync();
            return result;
        }

        public async Task<bool> Update(Entity.Entities.Ticket entity) 
        {
            _repository.Update(entity);
            await _repository.SaveAsync();
            return true;
        }  
        
    }
}
