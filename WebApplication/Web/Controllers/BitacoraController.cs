using WebApplication.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Web.Controllers
{
    public class BitacoraController : Controller
    {
      
        
            private readonly BitacoraRepository _repository;
            public BitacoraController(BitacoraRepository repository)
            {
                _repository = repository;
            }
            public IActionResult Index()
            {
                var eventos = _repository.GetAll();
                return View(eventos);
            }
        
    }

}
