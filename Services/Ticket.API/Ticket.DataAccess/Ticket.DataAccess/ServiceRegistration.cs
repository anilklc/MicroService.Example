using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DataAccess.Abstract;
using Ticket.DataAccess.Context;
using Ticket.DataAccess.Repositories;

namespace Ticket.DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services,IConfiguration configurtion)
        {
            services.AddDbContext<TicketDbContext>(options=>options.UseNpgsql(configurtion.GetConnectionString("SqlConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        }
    }
}
