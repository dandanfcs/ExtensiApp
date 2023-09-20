using ExtensiApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ExtensiApp.Data
{
    public class UsuarioDbContext : IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) :
        base(options)
        {

        }
        public class UsuarioDbContextFactory : IDesignTimeDbContextFactory<UsuarioDbContext>
        {
            public UsuarioDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UsuarioDbContext>();
                var builder = WebApplication.CreateBuilder(args);
                optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("UsuarioConnection"));
                return new UsuarioDbContext(optionsBuilder.Options);
            }
        }
    }
}
