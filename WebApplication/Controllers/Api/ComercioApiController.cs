using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioApiController : ControllerBase
    {
        private readonly ComercioBussines _business;

        public ComercioApiController(ComercioBussines business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_business.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _business.Obtener(id);

            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Comercio comercio)
        {
            try
            {
                _business.Registrar(comercio);
                return Ok(comercio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Comercio comercio)
        {
            try
            {
                _business.Editar(comercio);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
