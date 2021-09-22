using Microsoft.EntityFrameworkCore;
using Servicios.Modelo;

namespace Servicios
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
