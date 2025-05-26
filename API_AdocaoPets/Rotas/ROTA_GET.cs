using Microsoft.AspNetCore.Mvc;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.Rotas
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly PetContext _context;

        public PetsController(PetContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pet>> GetTodos()
        {
            var pets = _context.Pets.ToList();
            return Ok(pets); 
        }
    }
}