using Common.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FZintegrados.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroController : Controller
    {
        [HttpPost]
        public IActionResult AgregarRegistro([FromQuery] RegistroDeRecorredorDTO newRegistro)
        {
            return AgregarRegistro(newRegistro);
        }
    }
}
