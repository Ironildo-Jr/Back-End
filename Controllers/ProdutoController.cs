using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Tudo certo Produto");
        }
    }
}