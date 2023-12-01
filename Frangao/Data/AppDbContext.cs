using Frangao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Frangao.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Granja> Granjas { get; set; }
    }
}
