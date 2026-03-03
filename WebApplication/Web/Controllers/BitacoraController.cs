using Microsoft.AspNetCore.Mvc;
using WebApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Web.Controllers
{
    public class BitacoraController : Controller
    {
        private readonly AppDbContext _context;

        public BitacoraController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var eventos = await _context.BITACORA_EVENTOS.OrderByDescending(e => e.FechaDeEvento).ToListAsync();
            
            
            return View(eventos);


        }
        
    }

}