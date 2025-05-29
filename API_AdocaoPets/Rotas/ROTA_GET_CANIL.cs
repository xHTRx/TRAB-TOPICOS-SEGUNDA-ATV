// Rotas/ROTA_GET_CANIL.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.Rotas
{
    [ApiController]
    [Route("api/canis")]
    public class CanilGetController : ControllerBase
    {
        private readonly PetContext _context;
        public CanilGetController(PetContext context) => _context = context;

        [HttpGet]
        public IActionResult GetTodosCanis()
        {
            var canis = _context.Canis
                .Include(c => c.Pets)
                .ToList()
                .Select(c => new
                {
                    c.id,
                    c.local,
                    TotalPets = c.Pets.Count,
                    TotalCaes = c.Pets.Count(p => p.Especie.ToLower() == "cachorro"),
                    TotalGatos = c.Pets.Count(p => p.Especie.ToLower() == "gato")
                });

            return Ok(canis);
        }
    }
}