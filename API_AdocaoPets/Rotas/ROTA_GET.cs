// Rotas/ROTA_GET.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Context;
using API_AdocaoPets.src.Models;

namespace API_AdocaoPets.Rotas
{
    [ApiController]
    [Route("api/pets")]
    public class PetsGetController : ControllerBase
    {
        private readonly PetContext _context;
        public PetsGetController(PetContext context) => _context = context;

        [HttpGet]
        public ActionResult<IEnumerable<Pet>> GetTodos()
            => Ok(_context.Pets.ToList());

        [HttpGet("{id}", Name = "GetPetById")]
        public ActionResult<Pet> GetPorId(int id)
        {
            var pet = _context.Pets.Find(id);
            return pet is null ? NotFound() : Ok(pet);
        }
    }

    [ApiController]
    [Route("api/canis")]
    public class CanisGetController : ControllerBase
    {
        private readonly PetContext _context;
        public CanisGetController(PetContext context) => _context = context;

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