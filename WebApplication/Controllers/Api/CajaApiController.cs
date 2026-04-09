using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CajaApiController : ControllerBase
    {
        private readonly CajaBussiness _business;

        public CajaApiController(CajaBussiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_business.GetAllCajas());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var caja = _business.GetCajaById(id);

            if (caja == null)
                return NotFound();

            return Ok(caja);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Cajas caja)
        {
            try
            {
                _business.AddCaja(caja);
                return Ok(caja);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Cajas caja)
        {
            try
            {
                _business.UpdateCaja(caja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _business.DeleteCaja(id);
            return Ok();
        }
    }
}
