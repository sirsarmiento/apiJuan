using Microsoft.EntityFrameworkCore;
using ApiNet.Entities;
using Microsoft.AspNetCore.Identity;
using ApiNet.IdentityAuth;

namespace ApiNet.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationRol> ApplicationRol { get; set; }

    }
}
