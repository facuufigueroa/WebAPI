using Microsoft.EntityFrameworkCore;
using WebAPIPersona.Models;

namespace WebAPIPersona.Context
{
    public class AppDbContext: DbContext
    {

        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetSection("ConnectionString")["WebApiDatabase"]);
        }
        public DbSet<Personas> personas { get; set; }

    }
}
