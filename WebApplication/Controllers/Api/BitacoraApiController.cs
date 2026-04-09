using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitacoraApiController : ControllerBase
    {
        private readonly IBitacoraRepository _repo;

        public BitacoraApiController(IBitacoraRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = _repo.ObtenerTodos();
            return Ok(lista);
        }
    }
}
