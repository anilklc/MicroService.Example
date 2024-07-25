﻿using Event.Application.Interfaces;
using Event.Persistence.Context;
using Event.Persistence.Repositories.Event;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<EventDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("SqlConnection")));
            services.AddScoped<IEventReadRepository,EventReadRepository>();
            services.AddScoped<IEventWriteRepository,EventWriteRepository>();
        }

    }
}
