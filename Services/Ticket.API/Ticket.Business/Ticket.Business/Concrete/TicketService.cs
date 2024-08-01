using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Ticket.Business.Abstract;
using Ticket.DataAccess.Abstract;
using Ticket.Entity.DTOs;
using Ticket.Entity.Entities;

namespace Ticket.Business.Concrete
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Entity.Entities.Ticket> _repository;
        private readonly HttpClient _httpClient;

        public TicketService(DataAccess.Abstract.IRepository<Entity.Entities.Ticket> repository, HttpClient httpClient)
        {
            _repository = repository;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5000");
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

        public async Task<TicketByEventIdDto> GetTicketByEventId(string eventId)
        {
            var eventResult = await _httpClient.GetAsync($"/events/GetByIdEvent/{eventId}");
            var jsonContent = await eventResult.Content.ReadAsStringAsync();
            var eventData = JsonConvert.DeserializeObject<EventDto>(jsonContent);
            var tickets =  await _repository.GetWhere(t=>t.EventId == Guid.Parse(eventId)).ToListAsync();
            return new()
            {
                EventId = eventData.Id,
                EventName = eventData.Name,
                EventLocation = eventData.Location,
                EventCreatedDate = eventData.CreatedDate,
                Tickets = tickets,
            };

        }
        
    }
}
