using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                mensaje = "API funcionando correctamente",
                sistema = "SINPE Empresarial"
            });
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new
            {
                estado = "OK",
                servidor = DateTime.Now
            });
        }
    }
}
