
//Rotas/ROTA_RAIZ.cs
using Microsoft.AspNetCore.Mvc;

namespace API_AdocaoPets.Rotas
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}