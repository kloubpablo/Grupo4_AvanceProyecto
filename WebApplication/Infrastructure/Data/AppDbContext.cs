using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        
        
        {
        }

        public DbSet<BitacoraEvento> BITACORA_EVENTOS { get; set; }



    }
}