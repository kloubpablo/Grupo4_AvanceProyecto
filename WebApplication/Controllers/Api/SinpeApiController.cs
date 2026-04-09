using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Business;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinpeApiController : ControllerBase
    {
        private readonly SinpeBusiness _business;

        public SinpeApiController(SinpeBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_business.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Sinpe sinpe)
        {
            try
            {
                _business.Create(sinpe);
                return Ok(new { mensaje = "SINPE registrado correctamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
