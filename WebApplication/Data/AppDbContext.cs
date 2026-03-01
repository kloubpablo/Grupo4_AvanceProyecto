using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        ////////////////////// TABLAS DEL SISTEMA //////////////////////
        public DbSet<Comercio> Comercio { get; set; }
    }
}
