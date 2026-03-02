using Microsoft.EntityFrameworkCore;
using WebApplication.Domain.Entities;

namespace WebApplication.Infrastructure.Data
{
    public class AppDbContext
    {
        public DbSet<BitacoraEvento> BitacoraEventos { get; set; }
    }

    

}
