using WebApplication.Domain.Entities;
using WebApplication.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;


namespace WebApplication.Infraestructure.Repositories
{
    public class BitacoraRepository
    {
        private readonly AppDbContext _context;

        public BitacoraRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(BitacoraEvento evento)
        {
            _context.BitacoraEventos.Add(evento);
            _context.SaveChanges();
        }

        public List<BitacoraEvento> GetAll()
        {
            return _context.BitacoraEventos.OrderByDescending(e => e.Fecha).ToList();   
        }
    }
}
