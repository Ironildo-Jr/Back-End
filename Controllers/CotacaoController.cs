using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CotacaoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Tudo certo Cotacao");
        }
    }
}
