using Auth.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auth.API.Context
{
    public class AuthDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
