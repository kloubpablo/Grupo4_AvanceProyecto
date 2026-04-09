using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApiController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Usuario == "admin" && request.Password == "123")
            {
                return Ok(new
                {
                    mensaje = "Login correcto",
                    usuario = request.Usuario
                });
            }

            return Unauthorized(new
            {
                mensaje = "Usuario o contraseña incorrectos"
            });
        }
    }


    public class LoginRequest
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
