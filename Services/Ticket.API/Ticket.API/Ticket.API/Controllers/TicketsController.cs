using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket.Business.Abstract;
using Ticket.Entity.Entities;

namespace Ticket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [Authorize(AuthenticationSchemes ="Admin")]
        [HttpGet("[action]")] 
        public async Task<IActionResult> GetAllTicket() => Ok(_ticketService.GetAll());


        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdTicket(string id) => Ok(await _ticketService.GetById(id));

        [HttpPost("[action]")]
        public async Task<bool> CreateTicket(Entity.Entities.Ticket ticket) =>await _ticketService.AddAsync(ticket);

        [HttpPut("[action]")]
        public async Task<bool> UpdateTicket(Entity.Entities.Ticket ticket) =>  await _ticketService.Update(ticket);

        [HttpDelete("[action]")]
        public async Task<bool> RemoveEvent(string id) => await _ticketService.RemoveAsync(id);

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTicketByEventId(string eventId) => Ok(await _ticketService.GetTicketByEventId(eventId));
    }
}

