using Auth.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Persistence.Context
{
    public class AuthDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
