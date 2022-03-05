using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class FornecedorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Tudo certo Fornecedor");
        }
    }
}